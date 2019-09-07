using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Collections;

namespace ProjekRPL
{
    class Model_Post
    {
        static string connectionInfo = "datasource=localhost; port=3306; username=root; password=; database=projek_rpl;";
        MySqlConnection con = new MySqlConnection(connectionInfo);

        //Melihat seluruh list postingan
        static List<Image> listOfImages = new List<Image>();
        static List<String> listofJudul = new List<String>();
        static List<String> listofDesk = new List<String>();
        static List<String> listofMember = new List<String>();
        static List<String> listofID = new List<String>();
        static List<String> listofUsername = new List<String>();

        public List<Image> getlistImage()
        {
            return listOfImages;
        }
        public List<String> getlistOfJudul()
        {
            return listofJudul;
        }
        public List<String> getlistOfDesk()
        {
            return listofDesk;
        }
        public List<String> getlistOfMember()
        {
            return listofMember;
        }
        public List<String> getlistOfID()
        {
            return listofID;
        }
        public List<String> getlistOfUsername()
        {
            return listofUsername;
        }

        byte[] xx;
        MemoryStream ms;
        public void findPostSelected()
        {
            string query = "SELECT p.id, p.foto, p.judul, p.deskripsi, p.username, a.nama FROM post p " +
                            "join akun a on p.username = a.username order by p.id desc";

            int s = 0;

            MySqlCommand cmd;

            cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            con.Open();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                xx = (byte[])ds.Tables[0].Rows[s]["foto"];
                ms = new MemoryStream(xx);
                listOfImages.Add(new Bitmap(ms));
                listofJudul.Add(Convert.ToString(ds.Tables[0].Rows[s]["judul"]));
                listofDesk.Add(Convert.ToString(ds.Tables[0].Rows[s]["deskripsi"]));
                listofMember.Add(Convert.ToString(ds.Tables[0].Rows[s]["nama"]));
                listofID.Add(Convert.ToString(ds.Tables[0].Rows[s]["id"]));
                listofUsername.Add(Convert.ToString(ds.Tables[0].Rows[s]["username"]));
                s++;

            }
            con.Close();
        }


        //Menambahkan post baru
        public string AddNewPost(string judul, string deskripsi, string hasil_tani,
                                DateTime tgl_post, string foto, string stok, string lokasi, string provinsi,
                                string kota, string harga)
        {
            Form_Login fl = new Form_Login();

            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;

            string cek = "";
            try
            {
                if (judul.Equals("") || deskripsi.Equals("") || stok.Equals("") || lokasi.Equals("")
                    || harga.Equals("") || foto.Equals(""))
                {
                    cek = "Data harus terisi semua";
                }
                else
                {
                    string FileName = foto;
                    byte[] ImageData;
                    fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    string CmdString = "insert into post (id, judul, deskripsi, hasil_tani, tgl_post, foto, " +
                        "stok, lokasi, provinsi, kota, harga, username) values (NULL, @Judul, @Deskripsi, " +
                        "@Hasil, @Tgl, @Foto, @Stok, @Lokasi, @Provinsi, @Kota, @Harga, @Username)";

                    cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.Add("@Judul", MySqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@Deskripsi", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@Hasil", MySqlDbType.Enum);
                    cmd.Parameters.Add("@Tgl", MySqlDbType.Date);
                    cmd.Parameters.Add("@Foto", MySqlDbType.Blob);
                    cmd.Parameters.Add("@Stok", MySqlDbType.Int32);
                    cmd.Parameters.Add("@Lokasi", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Provinsi", MySqlDbType.Enum);
                    cmd.Parameters.Add("@Kota", MySqlDbType.Enum);
                    cmd.Parameters.Add("@Harga", MySqlDbType.Int32);
                    cmd.Parameters.Add("@Username", MySqlDbType.VarChar, 50);

                    cmd.Parameters["@Judul"].Value = judul;
                    cmd.Parameters["@Deskripsi"].Value = deskripsi;
                    cmd.Parameters["@Hasil"].Value = hasil_tani;
                    cmd.Parameters["@Tgl"].Value = tgl_post;
                    cmd.Parameters["@Foto"].Value = ImageData;
                    cmd.Parameters["@Stok"].Value = Int32.Parse(stok);
                    cmd.Parameters["@Lokasi"].Value = lokasi;
                    cmd.Parameters["@Provinsi"].Value = provinsi;
                    cmd.Parameters["@Kota"].Value = kota;
                    cmd.Parameters["@Harga"].Value = Int32.Parse(harga);
                    cmd.Parameters["@Username"].Value = fl.getusername();

                    con.Open();
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        cek = "Data berhasil di tambah";
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                cek = ex.ToString();
            }

            return cek;
        }

        //Melihat detail postingan
        public ArrayList findPostDetail(string idpost)
        {
            string judul, tgl, stok, lokasi, harga, deskripsi, hasil, prov,
                    kota, username;
            Image foto;

            MySqlCommand cmdJudul, cmdDesk, cmdHasil, cmdTgl, cmdStok, cmdLokasi,
                        cmdProv, cmdKota, cmdHarga, cmdFoto, cmdUsername;

            ArrayList tampil = new ArrayList();

            string cmd_Judul = "select judul from post where id = '" + idpost + "'";
            string cmd_Desk = "select deskripsi from post where id = '" + idpost + "'";
            string cmd_Hasil = "select hasil_tani from post where id = '" + idpost + "'";
            string cmd_Tgl = "select tgl_post from post where id = '" + idpost + "'";
            string cmd_Stok = "select stok from post where id = '" + idpost + "'";
            string cmd_Lokasi = "select lokasi from post where id = '" + idpost + "'";
            string cmd_Prov = "select provinsi from post where id = '" + idpost + "'";
            string cmd_Kota = "select kota from post where id = '" + idpost + "'";
            string cmd_Harga = "select harga from post where id = '" + idpost + "'";
            string cmd_Username = "select a.nama from akun a join post p  on p.username = a.username where p.id = '" + idpost + "'";

            cmdJudul = new MySqlCommand(cmd_Judul, con);
            cmdDesk = new MySqlCommand(cmd_Desk, con);
            cmdTgl = new MySqlCommand(cmd_Tgl, con);
            cmdStok = new MySqlCommand(cmd_Stok, con);
            cmdLokasi = new MySqlCommand(cmd_Lokasi, con);
            cmdHarga = new MySqlCommand(cmd_Harga, con);
            cmdHasil = new MySqlCommand(cmd_Hasil, con);
            cmdProv = new MySqlCommand(cmd_Prov, con);
            cmdKota = new MySqlCommand(cmd_Kota, con);
            cmdUsername = new MySqlCommand(cmd_Username, con);

            cmdFoto = new MySqlCommand("select foto from post where id='" + idpost + "'", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmdFoto);
            DataSet ds = new DataSet();
            da.Fill(ds);


            con.Open();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["foto"]);
                foto = new Bitmap(ms);
                tampil.Add(foto);

            }
            con.Close();

            con.Open();
            MySqlDataReader DR1 = cmdJudul.ExecuteReader();
            if (DR1.Read())
            {
                judul = DR1.GetValue(0).ToString();
                tampil.Add(judul);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR2 = cmdTgl.ExecuteReader();
            if (DR2.Read())
            {
                tgl = Convert.ToDateTime(DR2["tgl_post"]).ToString("dd/MM/yyyy");
                tampil.Add(tgl);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR3 = cmdStok.ExecuteReader();
            if (DR3.Read())
            {
                stok = DR3.GetValue(0).ToString();
                tampil.Add(stok);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR4 = cmdLokasi.ExecuteReader();
            if (DR4.Read())
            {
                lokasi = DR4.GetValue(0).ToString();
                tampil.Add(lokasi);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR5 = cmdHarga.ExecuteReader();
            if (DR5.Read())
            {
                harga = DR5.GetValue(0).ToString();
                tampil.Add(harga);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR6 = cmdDesk.ExecuteReader();
            if (DR6.Read())
            {
                deskripsi = DR6.GetValue(0).ToString();
                tampil.Add(deskripsi);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR7 = cmdHasil.ExecuteReader();
            if (DR7.Read())
            {
                hasil = DR7.GetValue(0).ToString();
                tampil.Add(hasil);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR8 = cmdProv.ExecuteReader();
            if (DR8.Read())
            {
                prov = DR8.GetValue(0).ToString();
                tampil.Add(prov);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR9 = cmdKota.ExecuteReader();
            if (DR9.Read())
            {
                kota = DR9.GetValue(0).ToString();
                tampil.Add(kota);
            }
            con.Close();

            con.Open();
            MySqlDataReader DR10 = cmdUsername.ExecuteReader();
            if (DR10.Read())
            {
                username = DR10.GetValue(0).ToString();
                tampil.Add(username);
            }
            con.Close();

            return tampil;
        }

        //Melakukan order pada postingan
        public string findOrdered(string idakun, string idpost, string tgl)
        {
            string pesan = "";

            string query = "insert into order_post(tgl_order, username, id) " +
                "values ('" + tgl + "', '" + idakun + "', '" + idpost + "')";

            MySqlDataReader reader;

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                pesan = "Berhasil diorder";
                con.Close();
            }
            catch (Exception ex)
            {
                pesan = ex.ToString();
            }

            return pesan;
        }
        
        //Melakukan edit post
        public string ProcessEdited(string judul, string deskripsi, string hasil_tani,
                                string foto, string stok, string lokasi, string provinsi,
                                string kota, string harga, string idpost)
        {
            Form_Login fl = new Form_Login();

            MySqlCommand cmd;
            FileStream fs;
            BinaryReader br;
            int RowsAffected = 0;
            string cek = "";

            try
            {
                if (judul.Equals("") || deskripsi.Equals("") || stok.Equals("") || lokasi.Equals("")
                    || harga.Equals(""))
                {
                    cek = "Data harus terisi semua";
                }
                if (foto.Length > 0)
                {
                    string FileName = foto;
                    byte[] ImageData;
                    fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    ImageData = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();

                    string CmdString = "update post set foto = @Foto where id = '"+idpost+"'";

                    cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.Add("@Foto", MySqlDbType.Blob);
                    cmd.Parameters["@Foto"].Value = ImageData;

                    con.Open();
                    RowsAffected = cmd.ExecuteNonQuery();
                    RowsAffected = 1;
                    con.Close();
                }
                if(judul.Length > 0)
                {
                    string Cmd = "update post set judul=@Judul, deskripsi=@Deskripsi, " +
                        "hasil_tani=@Hasil, stok=@Stok, lokasi=@Lokasi, provinsi=@Provinsi, " +
                        "kota=@Kota, harga=@Harga, username=@Username where id='"+idpost+"'";

                    cmd = new MySqlCommand(Cmd, con);

                    cmd.Parameters.Add("@Judul", MySqlDbType.VarChar, 50);
                    cmd.Parameters.Add("@Deskripsi", MySqlDbType.VarChar, 255);
                    cmd.Parameters.Add("@Hasil", MySqlDbType.Enum);
                    cmd.Parameters.Add("@Stok", MySqlDbType.Int32);
                    cmd.Parameters.Add("@Lokasi", MySqlDbType.VarChar, 100);
                    cmd.Parameters.Add("@Provinsi", MySqlDbType.Enum);
                    cmd.Parameters.Add("@Kota", MySqlDbType.Enum);
                    cmd.Parameters.Add("@Harga", MySqlDbType.Int32);
                    cmd.Parameters.Add("@Username", MySqlDbType.VarChar, 50);

                    cmd.Parameters["@Judul"].Value = judul;
                    cmd.Parameters["@Deskripsi"].Value = deskripsi;
                    cmd.Parameters["@Hasil"].Value = hasil_tani;
                    cmd.Parameters["@Stok"].Value = Int32.Parse(stok);
                    cmd.Parameters["@Lokasi"].Value = lokasi;
                    cmd.Parameters["@Provinsi"].Value = provinsi;
                    cmd.Parameters["@Kota"].Value = kota;
                    cmd.Parameters["@Harga"].Value = Int32.Parse(harga);
                    cmd.Parameters["@Username"].Value = fl.getusername();

                    con.Open();
                    RowsAffected = cmd.ExecuteNonQuery();
                    RowsAffected = 1;
                    con.Close();
                }
                if (RowsAffected > 0)
                {
                    cek = "Data berhasil di update";
                }
            }
            catch (Exception ex)
            {
                cek = ex.ToString();
            }

            return cek;
        }

        //Melakukan hapus postingan
        public String ProcessDeleted(string idpost)
        {
            string pesan = "";

            string query = "delete from post where id='"+idpost+"'";

            MySqlDataReader reader;

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                reader = cmd.ExecuteReader();
                pesan = "Berhasil dihapus";
                con.Close();
            }
            catch (Exception ex)
            {
                pesan = ex.ToString();
            }

            return pesan;
        }

        //Melakukan validasi Order
        public String OrderValidated(string idorder)
        {
            String pesan = "";
            string query = "update order_post set validasi = 'Validasi' where id_order = '" + idorder + "'";

            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            pesan = "Order berhasil divalidasi";
            con.Close();

            return pesan;
        }
    }
}

