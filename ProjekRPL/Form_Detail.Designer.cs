namespace ProjekRPL
{
    partial class Form_Detail
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKota = new System.Windows.Forms.TextBox();
            this.tbProv = new System.Windows.Forms.TextBox();
            this.tbHasil = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbLokasi = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbTgl = new System.Windows.Forms.TextBox();
            this.tbDesk = new System.Windows.Forms.TextBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Text = "Username";
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(255, 42);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(52, 20);
            this.tanggal.TabIndex = 21;
            this.tanggal.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Provinsi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hasil Tani";
            // 
            // tbKota
            // 
            this.tbKota.Enabled = false;
            this.tbKota.Location = new System.Drawing.Point(121, 420);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(186, 20);
            this.tbKota.TabIndex = 17;
            // 
            // tbProv
            // 
            this.tbProv.Enabled = false;
            this.tbProv.Location = new System.Drawing.Point(121, 393);
            this.tbProv.Name = "tbProv";
            this.tbProv.Size = new System.Drawing.Size(186, 20);
            this.tbProv.TabIndex = 16;
            // 
            // tbHasil
            // 
            this.tbHasil.Enabled = false;
            this.tbHasil.Location = new System.Drawing.Point(121, 286);
            this.tbHasil.Name = "tbHasil";
            this.tbHasil.Size = new System.Drawing.Size(186, 20);
            this.tbHasil.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(121, 486);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 23);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lokasi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tanggal Post";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deskripsi";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(230, 486);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(77, 23);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(38, 486);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbHarga
            // 
            this.tbHarga.Enabled = false;
            this.tbHarga.Location = new System.Drawing.Point(121, 446);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(186, 20);
            this.tbHarga.TabIndex = 6;
            // 
            // tbLokasi
            // 
            this.tbLokasi.Enabled = false;
            this.tbLokasi.Location = new System.Drawing.Point(121, 366);
            this.tbLokasi.Name = "tbLokasi";
            this.tbLokasi.Size = new System.Drawing.Size(186, 20);
            this.tbLokasi.TabIndex = 5;
            // 
            // tbStok
            // 
            this.tbStok.Enabled = false;
            this.tbStok.Location = new System.Drawing.Point(121, 339);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(186, 20);
            this.tbStok.TabIndex = 4;
            // 
            // tbTgl
            // 
            this.tbTgl.Enabled = false;
            this.tbTgl.Location = new System.Drawing.Point(121, 312);
            this.tbTgl.Name = "tbTgl";
            this.tbTgl.Size = new System.Drawing.Size(186, 20);
            this.tbTgl.TabIndex = 3;
            // 
            // tbDesk
            // 
            this.tbDesk.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbDesk.Enabled = false;
            this.tbDesk.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbDesk.Location = new System.Drawing.Point(121, 203);
            this.tbDesk.Multiline = true;
            this.tbDesk.Name = "tbDesk";
            this.tbDesk.Size = new System.Drawing.Size(186, 76);
            this.tbDesk.TabIndex = 2;
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(117, 168);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(125, 20);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul Ini Judul";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbFoto.Location = new System.Drawing.Point(121, 51);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(112, 98);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(204, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Belum Validasi";
            this.label9.Visible = false;
            // 
            // Form_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 528);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.tbProv);
            this.Controls.Add(this.tbHasil);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbLokasi);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbTgl);
            this.Controls.Add(this.tbDesk);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.pbFoto);
            this.Name = "Form_Detail";
            this.Text = "Form_Detail";
            this.Load += new System.EventHandler(this.Form_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.TextBox tbProv;
        private System.Windows.Forms.TextBox tbHasil;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbLokasi;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbTgl;
        private System.Windows.Forms.TextBox tbDesk;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
    }
}