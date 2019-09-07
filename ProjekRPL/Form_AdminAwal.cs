using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ProjekRPL
{
    public partial class Form_AdminAwal : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_rpl;");

        public static string listid;
        public static string listuser;

        public string getid()
        {
            return listid;
        }

        public string getuser()
        {
            return listuser;
        }

        private void pictureBox1_Click(object sender, EventArgs e, string n, string u)
        {
            this.Dispose();
            Form_AdminDeletePost frmd = new Form_AdminDeletePost();
            listid = n;
            this.Visible = false;
            frmd.ShowDialog();
        }
        public Form_AdminAwal()
        {
            InitializeComponent();
        }


        private void linkMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_AdminMember Hm = new Form_AdminMember();
            Hm.Show();
        }

        private void Form_HapusPost_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            string query = "SELECT p.id, p.foto, p.judul, p.deskripsi, p.username, a.nama FROM post p join akun a on p.username = a.username order by p.id desc";
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

            {
                Layout.Controls.Clear();

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
                    L.Text = listofJudul[i] + "\r\n" + listofDesk[i] + "\r\n" + listofMember[i];
                    L.Size = new Size(310, 80);
                    L.Padding = new Padding(15, 10, 15, 15);
                    Layout.Controls.Add(I);
                    Layout.Controls.Add(L);
                    Layout.AutoScroll = true;
                    string n = listofID[i];
                    string u = listofUsername[i];
                    I.Click += new EventHandler((snd, ev) => pictureBox1_Click(sender, e, n, u));
                }
            }
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin akan Logout?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Visible = false;
                Form_Postingan fp = new Form_Postingan();
                fp.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void linkOrderan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_AdminValidasi fp = new Form_AdminValidasi();
            fp.Show();
        }
    }
}
