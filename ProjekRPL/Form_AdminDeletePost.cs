using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekRPL
{
    public partial class Form_AdminDeletePost : Form
    {
        Form_AdminAwal fhp = new Form_AdminAwal();
        Controller control = new Controller();
        public static string idpost;

        public Form_AdminDeletePost()
        {
            InitializeComponent();
        }

        private void Form_Delete_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            idpost = fhp.getid();

            ArrayList xx = control.getPostDetail(idpost);

            pbFoto.Image = (Image)xx[0];
            lblJudul.Text = xx[1].ToString();
            tbTgl.Text = xx[2].ToString();
            tbStok.Text = xx[3].ToString();
            tbLokasi.Text = xx[4].ToString();
            tbHarga.Text = xx[5].ToString();
            tbDesk.Text = xx[6].ToString();
            tbHasil.Text = xx[7].ToString();
            tbProv.Text = xx[8].ToString();
            tbKota.Text = xx[9].ToString();
            lblUsername.Text = xx[10].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            fhp.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin akan menghapus?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String x = control.getDeleted(idpost);
                if (x.Equals("Berhasil dihapus"))
                {
                    MessageBox.Show(x);
                    this.Dispose();
                    fhp.ShowDialog();
                }
                else
                {
                    MessageBox.Show(x);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }
    }
}
