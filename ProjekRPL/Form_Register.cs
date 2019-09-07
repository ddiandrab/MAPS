using System;
using System.Windows.Forms;

namespace ProjekRPL
{
    public partial class Form_Register : Form
    {
        string foto, nama, alamat, email, nope, username, pass;
        DateTime tgl;

        public Form_Register()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            nama = tbNama.Text;
            alamat = tbAlamat.Text;
            email = tbEmail.Text;
            nope = tbNope.Text;
            username = tbUsername.Text;
            foto = tbFoto.Text;
            tgl = dtTtl.Value;
            pass = tbPassword.Text;

            Controller control = new Controller();
            string reg = control.getDataReg(foto, nama, tgl, alamat, email, nope, username, pass);

            if(reg.Equals("Data berhasil ditambah"))
            {
                MessageBox.Show(reg);
                this.Dispose();
                Form_Login fl = new Form_Login();
                fl.ShowDialog();
            }
            else
            {
                MessageBox.Show(reg);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form_Postingan f2 = new Form_Postingan();
            this.Visible = false;
            f2.Show();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.png;*.jpg)|*.jpeg;*.png;*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                tbFoto.Text = open.FileName;
            }
        }
    }
}
