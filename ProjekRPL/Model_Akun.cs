using System;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using System.Drawing;
using System.Collections;

namespace ProjekRPL
{
    class Model_Akun
    {
        static string connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projek_rpl";
        MySqlConnection con = new MySqlConnection(connectionInfo);
        
        //Melihat detail akun
        public ArrayList findMember(String username)
        {
            ArrayList ar = new ArrayList();

            MySqlCommand cmd, cmd2, cmdNama, cmdEmail, cmdNo, cmdTtl, cmdAlamat;

            Image foto;
            String nama, email, nope, tgl, lokasi;
            
            //lblUsername.Text = "desydb";

            string cmd_nama = "select nama from akun where username = '" + username + "'";
            string cmd_email = "select email from akun where username = '" + username + "'";
            string cmd_no = "select no_hp from akun where username = '" + username + "'";
            string cmd_ttl = "select tgl_lahir from akun where username = '" + username + "'";
            string cmd_alamat = "select lokasi from akun where username = '" + username + "'";

            cmdNama = new MySqlCommand(cmd_nama, con);
            cmdEmail = new MySqlCommand(cmd_email, con);
            cmdNo = new MySqlCommand(cmd_no, con);
            cmdTtl = new MySqlCommand(cmd_ttl, con);
            cmdAlamat = new MySqlCommand(cmd_alamat, con);

            cmd = new MySqlCommand("select foto from akun where username='" + username + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            con.Open();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["foto"]);
                foto = new Bitmap(ms);
                ar.Add(foto);//0

            }
            con.Close();

            con.Open();
            MySqlDataReader DR1 = cmdNama.ExecuteReader();
            if (DR1.Read())
            {
                nama = DR1.GetValue(0).ToString();
                ar.Add(nama);//1
            }
            con.Close();

            con.Open();
            MySqlDataReader DR2 = cmdEmail.ExecuteReader();
            if (DR2.Read())
            {
                email = DR2.GetValue(0).ToString();
                ar.Add(email);//2
            }
            con.Close();

            con.Open();
            MySqlDataReader DR3 = cmdNo.ExecuteReader();
            if (DR3.Read())
            {
                nope = DR3.GetValue(0).ToString();
                ar.Add(nope);//3
            }
            con.Close();

            con.Open();
            MySqlDataReader DR4 = cmdTtl.ExecuteReader();
            if (DR4.Read())
            {
                tgl = DR4.GetValue(0).ToString();
                ar.Add(tgl);//4
            }
            con.Close();

            con.Open();
            MySqlDataReader DR5 = cmdAlamat.ExecuteReader();
            if (DR5.Read())
            {
                lokasi = DR5.GetValue(0).ToString();
                ar.Add(lokasi);//5
            }
            con.Close();

            return ar;
        }

        //Menghapus member
        public String DeleteProcess(String idakun)
        {
            String pesan = "";
            MySqlDataReader reader;
            string query = "DELETE FROM user WHERE username = '"+idakun+"'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                pesan = "Berhasil Dihapus";
                con.Close();
            }
            catch (Exception ex)
            {
                pesan = ex.ToString();
            }

            return pesan;
        }
    }
}
