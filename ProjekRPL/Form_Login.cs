using System;
using System.Windows.Forms;

namespace ProjekRPL
{
    public partial class Form_Login : Form
    {

        private Controller control = new Controller();
        public static string username, password;

        public Form_Login()
        {
            InitializeComponent();
        }

        public string getusername()
        {
            return username;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            password = tbPass.Text;

            if(control.getLogin(username, password).Equals("berhasil"))
            {
                this.Dispose();
                Form_Awal fa = new Form_Awal();
                fa.ShowDialog();
            }
            else if(control.getLogin(username, password).Equals("berhasil1"))
            {
                this.Dispose();
                Form_AdminAwal fhp = new Form_AdminAwal();
                fhp.ShowDialog();
            }
            else
            {
                MessageBox.Show(control.getLogin(username, password));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Postingan fp = new Form_Postingan();
            fp.ShowDialog();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            this.ControlBox = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbPass.PasswordChar = '\0';
            }
            else
            {
                tbPass.PasswordChar = '*';
            }
        }
    }
}
