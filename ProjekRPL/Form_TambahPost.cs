using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekRPL
{
    public partial class Form_TambahPost : Form
    {
        string judul, deskripsi, hasil_tani, foto, stok, lokasi, provinsi, kota, harga;
        DateTime tgl_post;

        public Form_TambahPost()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Awal fh = new Form_Awal();
            fh.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            judul = tbJudul.Text;
            deskripsi = tbDeskripsi.Text;
            hasil_tani = cbHasil.Text;
            foto = tbFoto.Text;
            stok = tbStok.Text;
            lokasi = tbLokasi.Text;
            provinsi = cbProvinsi.Text;
            kota = cbKota.Text;
            harga = tbHarga.Text;
            tgl_post = date.Value;

            Controller control = new Controller();
            string xx = control.getNewPost(judul, deskripsi, hasil_tani, tgl_post, foto, stok,
                                            lokasi, provinsi, kota, harga);

            if(xx.Equals("Data berhasil ditambah"))
            {
                MessageBox.Show(xx);
                this.Dispose();
                Form_Awal fa = new Form_Awal();
                fa.ShowDialog();
            }
            else
            {
                MessageBox.Show(xx);
            }
           
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

        private void Form_TambahPost_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
