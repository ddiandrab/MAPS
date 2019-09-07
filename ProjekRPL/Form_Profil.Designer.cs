namespace ProjekRPL
{
    partial class Form_Profil
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.tbLokasi = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNope = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(28, 152);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(226, 20);
            this.tbNama.TabIndex = 1;
            this.tbNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(28, 179);
            this.date1.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date1.Size = new System.Drawing.Size(226, 20);
            this.date1.TabIndex = 3;
            this.date1.Value = new System.DateTime(2017, 11, 10, 3, 58, 38, 0);
            // 
            // tbLokasi
            // 
            this.tbLokasi.Location = new System.Drawing.Point(28, 206);
            this.tbLokasi.Name = "tbLokasi";
            this.tbLokasi.Size = new System.Drawing.Size(226, 20);
            this.tbLokasi.TabIndex = 4;
            this.tbLokasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(28, 233);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(226, 20);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNope
            // 
            this.tbNope.Location = new System.Drawing.Point(28, 260);
            this.tbNope.Name = "tbNope";
            this.tbNope.Size = new System.Drawing.Size(226, 20);
            this.tbNope.TabIndex = 6;
            this.tbNope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(104, 298);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(119, 114);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(46, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "label1";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(88, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(107, 89);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // Form_Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(281, 344);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbNope);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLokasi);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.pbFoto);
            this.Name = "Form_Profil";
            this.Text = "Form_Profil";
            this.Load += new System.EventHandler(this.Form_Profil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.TextBox tbLokasi;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNope;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUsername;
    }
}