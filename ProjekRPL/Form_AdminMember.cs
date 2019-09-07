using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ProjekRPL
{

    public partial class Form_AdminMember : Form
    {
        public Form_AdminMember()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_rpl;");

        public static string listid;

        public string getid()
        {
            return listid;
        }

        private void pictureBox1_Click(object sender, EventArgs e, string n)
        {
            this.Dispose();
            Form_AdminDeleteMember frmd = new Form_AdminDeleteMember();
            listid = n;
            this.Visible = false;
            frmd.ShowDialog();
        }

        private void Form_AdminMember_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            string query = "SELECT username, nama, foto FROM akun where id_akun != 1 ";
            List<Image> listOfImages = new List<Image>();
            List<String> listofid = new List<String>();
            List<String> listofnama = new List<String>();
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


                listofnama.Add(Convert.ToString(ds.Tables[0].Rows[s]["nama"]));
                listofid.Add(Convert.ToString(ds.Tables[0].Rows[s]["username"]));
                s++;

            }
            con.Close();

            {
                Layout2.Controls.Clear();

                int x = 0; //Initialize X as int of value 0
                int y = 0; //Initialize Y as int of value 0
                for (int i = 0; i < listOfImages.Count; i++)
                {
                    PictureBox I = new PictureBox(); //Initialize a new PictureBox of name I
                    Label L = new Label();
                    I.Location = new Point(x, y); //Set the PictureBox location to x,y
                    x += 50; //Sort horizontally; Increment x by 50
                    //y += 50; //Sort vertically; Increment y by 50
                    I.Image = listOfImages[i]; //Set the Image property of I to i in ImagesInFolder as index
                    I.Size = new Size(80, 80);
                    I.SizeMode = PictureBoxSizeMode.StretchImage;
                    L.Text = listofnama[i];
                    L.Size = new Size(310, 80);
                    L.Padding = new Padding(15, 10, 15, 15);
                    Layout2.Controls.Add(I);
                    Layout2.Controls.Add(L);
                    Layout2.AutoScroll = true;
                    string n = listofid[i];
                    I.Click += new EventHandler((snd, ev) => pictureBox1_Click(sender, e, n));
                }
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin akan Logout?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
                Form_Postingan fp = new Form_Postingan();
                fp.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void linkPostingan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_AdminAwal Hp = new Form_AdminAwal();
            Hp.ShowDialog();
        }

        private void linkOrderan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_AdminValidasi Hp = new Form_AdminValidasi();
            Hp.ShowDialog();
        }

        private void linkLogout_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin akan Logout?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
                Form_AdminAwal fp = new Form_AdminAwal();
                fp.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }
    }
}

