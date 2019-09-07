using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace ProjekRPL
{
    public partial class Form_Profil : Form
    {
        public static string username;
        Controller control = new Controller();

        public Form_Profil()
        {
            InitializeComponent();
        }

        private void Form_Profil_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            Form_Login f1 = new Form_Login();
            username = f1.getusername();
            lblUsername.Text = username;

            ArrayList arl = control.getMember(username);
            try
            {
                pbFoto.Image = (Image)arl[0];
                tbNama.Text = arl[1].ToString();
                date1.Text = arl[4].ToString();
                tbLokasi.Text = arl[5].ToString();
                tbEmail.Text = arl[2].ToString();
                tbNope.Text = arl[3].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_Awal fa = new Form_Awal();
            this.Visible = false;
            fa.Show();
        }
    }
}
