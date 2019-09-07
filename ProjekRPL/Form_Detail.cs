using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekRPL
{
    public partial class Form_Detail : Form
    {
        Form_Awal frmawal = new Form_Awal();
        Form_OrderSaya frmor = new Form_OrderSaya();
        Form_Login frmlog = new Form_Login();

        Controller control = new Controller();

        public static string idpost;
        public static string user_log;
        public static string user_post;
        public static string fromasal;

        public Form_Detail(string from)
        {
            InitializeComponent();
            fromasal = from;
        }

        private void Form_Detail_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            user_log = frmlog.getusername();
            if (fromasal.Equals("form_awal"))
            {
                idpost = frmawal.getid();
                user_post = frmawal.getuser();
            } else if (fromasal.Equals("form_order"))
            {
                idpost = frmor.getid();
            }
            
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

            if (user_post.Equals(user_log))
            {
                this.btnOrder.Visible = false;
                this.btnOrder.Enabled = false;
                this.btnEdit.Visible = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Visible = true;
                this.btnDelete.Enabled = true;
            }
            else
            {
                this.btnOrder.Visible = true;
                this.btnOrder.Enabled = true;
                this.btnEdit.Visible = false;
                this.btnEdit.Enabled = false;
                this.btnDelete.Visible = false;
                this.btnDelete.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Dispose();
           frmawal.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string tgl = tanggal.Value.Date.ToString("yyyyMMdd");

            DialogResult dialogResult = MessageBox.Show("Anda yakin akan mengorder?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string aa = control.getOrdered(user_log, idpost, tgl);
                MessageBox.Show(aa);
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form_UpdatePost fup = new Form_UpdatePost();
            fup.ShowDialog();
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
                    frmawal.ShowDialog();
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
