using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace ProjekRPL
{
    class Model_User
    {
        static string connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projek_rpl;";
        MySqlConnection connect = new MySqlConnection(connectionInfo);

        //Cek Login User
        public string cekLogin(string username, string pass)
        {
            string berhasil = "";

            string query =
                "select * from user where username = '" + username + "';";
            MySqlDataReader reader;

            try
            {
                connect.Open();
                MySqlCommand SQLCommand = new MySqlCommand(query, connect);
                reader = SQLCommand.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count = count + 1;
                }

                if (count == 1 && pass == reader["password"].ToString())
                {
                    if(reader["hak_akses"].ToString().Equals("1"))
                    {
                        berhasil = "berhasil1";
                    }
                    else
                    {
                        username = reader["username"].ToString();
                        berhasil = "berhasil";
                    }
                }
                else if (count == 1 && pass != reader["password"].ToString())
                {
                    berhasil = "Password Salah";
                }
                else if (count == 0)
                {
                    berhasil = "Akun belum terdaftar";
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                berhasil = ex.Message;
            }
            return berhasil;
        }

        //User melakukan register
        public string AddNewUser(string foto, string nama, DateTime tgl,
            string alamat, string email, string nope, string username, string password)
        {
            string cek = "";

            string query =
                "insert into akun(nama, tgl_lahir, lokasi, email, no_hp, foto, username)" +
                " values (@Nama, @Tgl, @Lokasi, @Email, @Nope, @Foto, @Username)";

            string query2 =
                "insert into user(username, password)" +
                " values ('" + username + "','" + password + "')";

            string FileName = "";
            FileStream fs;
            BinaryReader br;
            byte[] ImageData = new byte[1000];

            if (foto.Equals(""))
            {
                cek = "Data harus terisi semua";
            }
            else
            {
                FileName = foto;
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
            }

            MySqlCommand SQLCommand = new MySqlCommand(query, connect);
            MySqlCommand cmd = new MySqlCommand(query2, connect);


            SQLCommand.Parameters.Add("@Nama", MySqlDbType.VarChar, 50);
            SQLCommand.Parameters.Add("@Tgl", MySqlDbType.Date);
            SQLCommand.Parameters.Add("@Lokasi", MySqlDbType.VarChar, 100);
            SQLCommand.Parameters.Add("@Email", MySqlDbType.VarChar, 100);
            SQLCommand.Parameters.Add("@Nope", MySqlDbType.VarChar, 50);
            SQLCommand.Parameters.Add("@Foto", MySqlDbType.Blob);
            SQLCommand.Parameters.Add("@Username", MySqlDbType.VarChar, 50);

            SQLCommand.Parameters["@Nama"].Value = nama;
            SQLCommand.Parameters["@Tgl"].Value = tgl;
            SQLCommand.Parameters["@Lokasi"].Value = alamat;
            SQLCommand.Parameters["@Email"].Value = email;
            SQLCommand.Parameters["@Nope"].Value = nope;
            SQLCommand.Parameters["@Foto"].Value = ImageData;
            SQLCommand.Parameters["@Username"].Value = username;

            try
            {
                if (nama.Equals("") || alamat.Equals("") || email.Equals("") || nope.Equals("")
                    || foto.Equals("") || username.Equals("") || password.Equals(""))
                {
                    cek = "Data harus terisi semua";
                }
                else
                {
                    connect.Open();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    connect.Close();

                    connect.Open();
                    int RowsAffected = SQLCommand.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        cek = "Data berhasil di tambah";
                    }
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                cek = ex.ToString();
            }

            return cek;
        }
    }
}
