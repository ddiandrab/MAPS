using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekRPL
{
    public partial class Form_UpdatePost : Form
    {
        Form_Awal frmawal = new Form_Awal();
        Controller control = new Controller();

        public static string idpost;

        public Form_UpdatePost()
        {
            InitializeComponent();
        }

        private void Form_UpdatePost_Load(object sender, EventArgs e)
        {
            idpost = frmawal.getid();
            
            ArrayList xx = control.getPostDetail(idpost);

            pbFoto.Image = (Image)xx[0];
            tbJudul.Text = xx[1].ToString();
            tbStok.Text = xx[3].ToString();
            tbLokasi.Text = xx[4].ToString();
            tbHarga.Text = xx[5].ToString();
            tbDeskripsi.Text = xx[6].ToString();
            cbHasil.Text = xx[7].ToString();
            cbProvinsi.Text = xx[8].ToString();
            cbKota.Text = xx[9].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String x = control.getEdited(tbJudul.Text, tbDeskripsi.Text, cbHasil.Text, tbFoto.Text,
                                        tbStok.Text, tbLokasi.Text, cbProvinsi.Text, cbKota.Text,
                                        tbHarga.Text, idpost);
            if(x.Equals("Data berhasil di update"))
            {
                MessageBox.Show(x);
                this.Dispose();
                Form_Awal fa = new Form_Awal();
                fa.ShowDialog();
            }
            else
            {
                MessageBox.Show(x);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_Awal fa = new Form_Awal();
            fa.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.png;*.jpg)|*.jpeg;*.png;*.jpg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                tbFoto.Text = open.FileName;
                pbFoto.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
