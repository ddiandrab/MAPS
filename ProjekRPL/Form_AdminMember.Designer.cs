namespace ProjekRPL
{
    partial class Form_AdminMember
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
            this.linkOrderan = new System.Windows.Forms.LinkLabel();
            this.Layout2 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkPostingan = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkOrderan
            // 
            this.linkOrderan.AutoSize = true;
            this.linkOrderan.Location = new System.Drawing.Point(313, 16);
            this.linkOrderan.Name = "linkOrderan";
            this.linkOrderan.Size = new System.Drawing.Size(45, 13);
            this.linkOrderan.TabIndex = 35;
            this.linkOrderan.TabStop = true;
            this.linkOrderan.Text = "Orderan";
            this.linkOrderan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOrderan_LinkClicked);
            // 
            // Layout2
            // 
            this.Layout2.BackColor = System.Drawing.Color.LemonChiffon;
            this.Layout2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Layout2.Location = new System.Drawing.Point(28, 113);
            this.Layout2.Name = "Layout2";
            this.Layout2.Size = new System.Drawing.Size(446, 260);
            this.Layout2.TabIndex = 34;
            // 
            // linkPostingan
            // 
            this.linkPostingan.AutoSize = true;
            this.linkPostingan.Location = new System.Drawing.Point(364, 16);
            this.linkPostingan.Name = "linkPostingan";
            this.linkPostingan.Size = new System.Drawing.Size(54, 13);
            this.linkPostingan.TabIndex = 33;
            this.linkPostingan.TabStop = true;
            this.linkPostingan.Text = "Postingan";
            this.linkPostingan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPostingan_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Daftar Semua Member :";
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(424, 16);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLogout.TabIndex = 31;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Exotc350 Bd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 38);
            this.label10.TabIndex = 30;
            this.label10.Text = "MARKETING AGRICULTURAL\r\nPRODUCT SOLUTIONS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_AdminMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 404);
            this.Controls.Add(this.linkOrderan);
            this.Controls.Add(this.Layout2);
            this.Controls.Add(this.linkPostingan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.label10);
            this.Name = "Form_AdminMember";
            this.Text = "Form_AdminMember";
            this.Load += new System.EventHandler(this.Form_AdminMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkOrderan;
        private System.Windows.Forms.FlowLayoutPanel Layout2;
        private System.Windows.Forms.LinkLabel linkPostingan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.Label label10;
    }
}