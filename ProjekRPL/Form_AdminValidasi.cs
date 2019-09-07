using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjekRPL
{
    public partial class Form_AdminValidasi : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=projek_rpl;");
        
        Controller control = new Controller();

        public static string idorder;
        public static int selectedRow;

        public string getid()
        {
            return idorder;
        }

        public Form_AdminValidasi()
        {
            InitializeComponent();
        }

        private void linkMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_AdminMember Hm = new Form_AdminMember();
            Hm.Show();
        }

        private void Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin akan Logout?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Dispose();
                Form_AdminAwal fp = new Form_AdminAwal();
                fp.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void linkPostingan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form_AdminAwal fp = new Form_AdminAwal();
            fp.Show();
        }

        private void btnValidasi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin akan Validasi?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String a = control.getValidation(idorder);
                if(a.Equals("Order berhasil divalidasi"))
                {
                    MessageBox.Show(a);
                    DataGridViewRow baru = dgOrder.Rows[selectedRow];
                    baru.Cells[2].Value = "Validasi";
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void dgOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String valid = dgOrder.SelectedCells[2].Value.ToString();
            selectedRow = e.RowIndex;

            if (valid.Equals("Belum Validasi"))
            {
                btnValidasi.Enabled = true;
                idorder = dgOrder.SelectedCells[0].Value.ToString();
            }else if (valid.Equals("Validasi"))
            {
                btnValidasi.Enabled = false;
            }
        }

        private void Form_AdminValidasi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            string query = "SELECT o.id_order, o.tgl_order, o.validasi, o.username, p.judul FROM order_post o" +
                           " join post p on o.id = p.id";
            dgOrder.Rows.Clear();

            MySqlCommand cmd = new MySqlCommand(query, con);

            con.Open();
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                dgOrder.Rows.Add(read[0], read[1], read[2], read[3]);
            }
            con.Close();
        }

        private void linkPostingan_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            Form_AdminAwal faw = new Form_AdminAwal();
            faw.ShowDialog();
        }
    }
}
