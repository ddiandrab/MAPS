namespace ProjekRPL
{
    partial class Form_AdminValidasi
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
            this.Logout = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkMember = new System.Windows.Forms.LinkLabel();
            this.linkPostingan = new System.Windows.Forms.LinkLabel();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Location = new System.Drawing.Point(412, 18);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(40, 13);
            this.Logout.TabIndex = 13;
            this.Logout.TabStop = true;
            this.Logout.Text = "Logout";
            this.Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 38);
            this.label10.TabIndex = 12;
            this.label10.Text = "MARKETING AGRICULTURAL\r\nPRODUCT SOLUTIONS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Daftar Semua Orderan :";
            // 
            // linkMember
            // 
            this.linkMember.AutoSize = true;
            this.linkMember.Location = new System.Drawing.Point(366, 18);
            this.linkMember.Name = "linkMember";
            this.linkMember.Size = new System.Drawing.Size(45, 13);
            this.linkMember.TabIndex = 15;
            this.linkMember.TabStop = true;
            this.linkMember.Text = "Member";
            this.linkMember.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMember_LinkClicked);
            // 
            // linkPostingan
            // 
            this.linkPostingan.AutoSize = true;
            this.linkPostingan.Location = new System.Drawing.Point(310, 18);
            this.linkPostingan.Name = "linkPostingan";
            this.linkPostingan.Size = new System.Drawing.Size(54, 13);
            this.linkPostingan.TabIndex = 28;
            this.linkPostingan.TabStop = true;
            this.linkPostingan.Text = "Postingan";
            this.linkPostingan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPostingan_LinkClicked_1);
            // 
            // dgOrder
            // 
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_order,
            this.tgl_order,
            this.validasi,
            this.username,
            this.id_post});
            this.dgOrder.Location = new System.Drawing.Point(31, 124);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.Size = new System.Drawing.Size(408, 221);
            this.dgOrder.TabIndex = 29;
            this.dgOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOrder_CellMouseClick);
            // 
            // id_order
            // 
            this.id_order.HeaderText = "ID Order";
            this.id_order.Name = "id_order";
            // 
            // tgl_order
            // 
            this.tgl_order.HeaderText = "Tanggal Order";
            this.tgl_order.Name = "tgl_order";
            // 
            // validasi
            // 
            this.validasi.HeaderText = "Status";
            this.validasi.Name = "validasi";
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            // 
            // id_post
            // 
            this.id_post.HeaderText = "Judul Post";
            this.id_post.Name = "id_post";
            // 
            // btnValidasi
            // 
            this.btnValidasi.Enabled = false;
            this.btnValidasi.Location = new System.Drawing.Point(193, 375);
            this.btnValidasi.Name = "btnValidasi";
            this.btnValidasi.Size = new System.Drawing.Size(75, 23);
            this.btnValidasi.TabIndex = 30;
            this.btnValidasi.Text = "Validasi";
            this.btnValidasi.UseVisualStyleBackColor = true;
            this.btnValidasi.Click += new System.EventHandler(this.btnValidasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "*Klik kolom untuk validasi";
            // 
            // Form_AdminValidasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidasi);
            this.Controls.Add(this.dgOrder);
            this.Controls.Add(this.linkPostingan);
            this.Controls.Add(this.linkMember);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label10);
            this.Name = "Form_AdminValidasi";
            this.Text = "Form_HapusPost";
            this.Load += new System.EventHandler(this.Form_AdminValidasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkMember;
        private System.Windows.Forms.LinkLabel linkPostingan;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.Button btnValidasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn validasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_post;
        private System.Windows.Forms.Label label1;
    }
}