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
    public partial class Form_OrderSaya : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_rpl;");
        Form_Login fa = new Form_Login();

        public Form_OrderSaya()
        {
            InitializeComponent();
        }

        public static string listid;
        public static string formini = "form_order";

        public string getid()
        {
            return listid;
        }

        private void pictureBox1_Click(object sender, EventArgs e, string n)
        {
            Form_Detail frmd = new Form_Detail(formini);
            listid = n;
            frmd.ShowDialog();
        }

        private void Form_OrderSaya_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            string query = "SELECT p.id, p.foto, p.judul, p.deskripsi FROM post p join order_post x on p.id = x.id where x.username = '"+fa.getusername()+"' order by x.id_order desc";
            List<Image> listOfImages = new List<Image>();
            List<String> listofJudul = new List<String>();
            List<String> listofDesk = new List<String>();
          //  List<String> listofMember = new List<String>();
            List<String> listofID = new List<String>();
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
                //listofMember.Add(Convert.ToString(ds.Tables[0].Rows[s]["nama"]));
                listofID.Add(Convert.ToString(ds.Tables[0].Rows[s]["id"]));
                s++;

            }
            con.Close();

            {
                flowLayoutPanel1.Controls.Clear();

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
                    L.Text = listofJudul[i] + "\r\n" + listofDesk[i];
                    L.Size = new Size(310, 80);
                    L.Padding = new Padding(15, 10, 15, 15);
                    flowLayoutPanel1.Controls.Add(I);
                    flowLayoutPanel1.Controls.Add(L);
                    flowLayoutPanel1.AutoScroll = true;
                    string n = listofID[i];
                    I.Click += new EventHandler((snd, ev) => pictureBox1_Click(sender, e, n));
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Awal fa = new Form_Awal();
            fa.ShowDialog();
        }
    }
}
