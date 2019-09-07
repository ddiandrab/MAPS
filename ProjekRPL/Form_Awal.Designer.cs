namespace ProjekRPL
{
    partial class Form_Awal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkProfil = new System.Windows.Forms.LinkLabel();
            this.btnTambah = new System.Windows.Forms.Button();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbProvinsi = new System.Windows.Forms.ComboBox();
            this.cbKota = new System.Windows.Forms.ComboBox();
            this.linkOrder = new System.Windows.Forms.LinkLabel();
            this.cbHasil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // linkProfil
            // 
            this.linkProfil.AutoSize = true;
            this.linkProfil.Location = new System.Drawing.Point(324, 9);
            this.linkProfil.Name = "linkProfil";
            this.linkProfil.Size = new System.Drawing.Size(30, 13);
            this.linkProfil.TabIndex = 25;
            this.linkProfil.TabStop = true;
            this.linkProfil.Text = "Profil";
            this.linkProfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProfil_LinkClicked);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.White;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(33, 447);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(419, 32);
            this.btnTambah.TabIndex = 24;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(426, 9);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLogout.TabIndex = 23;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(135, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 38);
            this.label10.TabIndex = 22;
            this.label10.Text = "MARKETING AGRICULTURAL\r\nPRODUCT SOLUTIONS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(33, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(419, 277);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // cbProvinsi
            // 
            this.cbProvinsi.FormattingEnabled = true;
            this.cbProvinsi.Items.AddRange(new object[] {
            "Jawa Timur"});
            this.cbProvinsi.Location = new System.Drawing.Point(33, 114);
            this.cbProvinsi.Name = "cbProvinsi";
            this.cbProvinsi.Size = new System.Drawing.Size(121, 21);
            this.cbProvinsi.TabIndex = 27;
            this.cbProvinsi.Text = "-Cari Provinsi-";
            this.cbProvinsi.SelectedIndexChanged += new System.EventHandler(this.cbProvinsi_SelectedIndexChanged);
            // 
            // cbKota
            // 
            this.cbKota.FormattingEnabled = true;
            this.cbKota.Items.AddRange(new object[] {
            "Banyuwangi",
            "Blitar",
            "Jember",
            "Kediri",
            "Malang",
            "Surabaya"});
            this.cbKota.Location = new System.Drawing.Point(180, 114);
            this.cbKota.Name = "cbKota";
            this.cbKota.Size = new System.Drawing.Size(121, 21);
            this.cbKota.TabIndex = 28;
            this.cbKota.Text = "-Cari Kota-";
            this.cbKota.SelectedIndexChanged += new System.EventHandler(this.cbKota_SelectedIndexChanged);
            // 
            // linkOrder
            // 
            this.linkOrder.AutoSize = true;
            this.linkOrder.Location = new System.Drawing.Point(360, 9);
            this.linkOrder.Name = "linkOrder";
            this.linkOrder.Size = new System.Drawing.Size(60, 13);
            this.linkOrder.TabIndex = 29;
            this.linkOrder.TabStop = true;
            this.linkOrder.Text = "Order Saya";
            this.linkOrder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOrder_LinkClicked);
            // 
            // cbHasil
            // 
            this.cbHasil.FormattingEnabled = true;
            this.cbHasil.Items.AddRange(new object[] {
            "Jagung",
            "Kentang",
            "Sawi",
            "Kubis",
            "Tomat",
            "Beras",
            "Kopi"});
            this.cbHasil.Location = new System.Drawing.Point(331, 114);
            this.cbHasil.Name = "cbHasil";
            this.cbHasil.Size = new System.Drawing.Size(121, 21);
            this.cbHasil.TabIndex = 30;
            this.cbHasil.Text = "-Cari Hasil Tani-";
            this.cbHasil.SelectedIndexChanged += new System.EventHandler(this.cbHasil_SelectedIndexChanged);
            // 
            // Form_Awal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 496);
            this.Controls.Add(this.cbHasil);
            this.Controls.Add(this.linkOrder);
            this.Controls.Add(this.cbKota);
            this.Controls.Add(this.cbProvinsi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.linkProfil);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.label10);
            this.Name = "Form_Awal";
            this.Text = "Form_Awal";
            this.Load += new System.EventHandler(this.Form_Awal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkProfil;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbProvinsi;
        private System.Windows.Forms.ComboBox cbKota;
        private System.Windows.Forms.LinkLabel linkOrder;
        private System.Windows.Forms.ComboBox cbHasil;
    }
}