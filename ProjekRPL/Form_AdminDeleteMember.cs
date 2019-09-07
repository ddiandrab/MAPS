using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace ProjekRPL
{
    public partial class Form_AdminDeleteMember : Form
    {
        Controller control = new Controller();
        Form_AdminMember fam = new Form_AdminMember();

        public static string idakun;

        public Form_AdminDeleteMember()
        {
            InitializeComponent();
        }

        private void Form_Profil_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            idakun = fam.getid();

            ArrayList arl = control.getMember(idakun);
            try
            {
                pbFoto.Image = (Image)arl[0];
                tbNama.Text = arl[1].ToString();
                date1.Text = arl[4].ToString();
                tbLokasi.Text = arl[5].ToString();
                tbEmail.Text = arl[2].ToString();
                tbNope.Text = arl[3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            fam.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin akan menghapus?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String x = control.getAccountSelected(idakun);
                if (x.Equals("Berhasil dihapus"))
                {
                    MessageBox.Show(x);
                    this.Dispose();
                    fam.ShowDialog();
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
