using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ProjekRPL
{
    public partial class Form_Postingan : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_rpl;");

        Controller control = new Controller();

        public static string listid;
        public static string listuser;

        public Form_Postingan()
        {
            InitializeComponent();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_Login fl = new Form_Login();
            fl.Show();
        }

        private void Form_Postingan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Register fr = new Form_Register();
            this.Visible = false;
            fr.Show();
        }

        private void Form_Postingan_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            /*listOfImages = control.getlistImage();
            listofJudul = control.getlistOfJudul();
            listofDesk = control.getlistOfDesk();
            listofMember = control.getlistOfMember();
            listofID = control.getlistOfID();
            listofUsername = control.getlistOfUsername();*/

            string query = "SELECT p.id, p.foto, p.judul, p.deskripsi, p.username, a.nama FROM post p " +
                            "join akun a on p.username = a.username order by p.id desc";

            List<Image> listOfImages = new List<Image>();
            List<String> listofJudul = new List<String>();
            List<String> listofDesk = new List<String>();
            List<String> listofMember = new List<String>();
            List<String> listofID = new List<String>();
            List<String> listofUsername = new List<String>();
            int s = 0;

            MySqlCommand cmd;

            cmd = new MySqlCommand(query, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            con.Open();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                byte[] xx = (byte[])ds.Tables[0].Rows[s]["foto"];
                MemoryStream ms = new MemoryStream(xx);
                listOfImages.Add(new Bitmap(ms));
                listofJudul.Add(Convert.ToString(ds.Tables[0].Rows[s]["judul"]));
                listofDesk.Add(Convert.ToString(ds.Tables[0].Rows[s]["deskripsi"]));
                listofMember.Add(Convert.ToString(ds.Tables[0].Rows[s]["nama"]));
                listofID.Add(Convert.ToString(ds.Tables[0].Rows[s]["id"]));
                listofUsername.Add(Convert.ToString(ds.Tables[0].Rows[s]["username"]));
                s++;

            }
            con.Close();

            int x = 0;
            int y = 0;
            for (int i = 0; i < listOfImages.Count; i++)
            {
                PictureBox I = new PictureBox();
                Label L = new Label();
                I.Location = new Point(x, y); //Set the PictureBox location to x,y
                x += 50; //Sort horizontally; Increment x by 50
                         //y += 50; //Sort vertically; Increment y by 50
                I.Image = listOfImages[i];
                I.Size = new Size(80, 80);
                I.SizeMode = PictureBoxSizeMode.StretchImage;
                L.Text = listofJudul[i] + "\r\n" + listofDesk[i] + "\r\n" + listofMember[i];
                L.Size = new Size(310, 80);
                L.Padding = new Padding(15, 10, 15, 15);
                flowLayoutPanel1.Controls.Add(I);
                flowLayoutPanel1.Controls.Add(L);
                flowLayoutPanel1.AutoScroll = true;
            }
        }
    }
}
