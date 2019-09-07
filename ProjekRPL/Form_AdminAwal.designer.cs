namespace ProjekRPL
{
    partial class Form_AdminAwal
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
            this.Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.linkOrderan = new System.Windows.Forms.LinkLabel();
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
            this.label11.Size = new System.Drawing.Size(194, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Daftar Semua Postingan :";
            // 
            // linkMember
            // 
            this.linkMember.AutoSize = true;
            this.linkMember.Location = new System.Drawing.Point(361, 18);
            this.linkMember.Name = "linkMember";
            this.linkMember.Size = new System.Drawing.Size(45, 13);
            this.linkMember.TabIndex = 15;
            this.linkMember.TabStop = true;
            this.linkMember.Text = "Member";
            this.linkMember.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMember_LinkClicked);
            // 
            // Layout
            // 
            this.Layout.BackColor = System.Drawing.Color.LemonChiffon;
            this.Layout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Layout.Location = new System.Drawing.Point(15, 125);
            this.Layout.Name = "Layout";
            this.Layout.Size = new System.Drawing.Size(446, 260);
            this.Layout.TabIndex = 27;
            // 
            // linkOrderan
            // 
            this.linkOrderan.AutoSize = true;
            this.linkOrderan.Location = new System.Drawing.Point(310, 18);
            this.linkOrderan.Name = "linkOrderan";
            this.linkOrderan.Size = new System.Drawing.Size(45, 13);
            this.linkOrderan.TabIndex = 28;
            this.linkOrderan.TabStop = true;
            this.linkOrderan.Text = "Orderan";
            this.linkOrderan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOrderan_LinkClicked);
            // 
            // Form_HapusPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 397);
            this.Controls.Add(this.linkOrderan);
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.linkMember);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label10);
            this.Name = "Form_HapusPost";
            this.Text = "Form_HapusPost";
            this.Load += new System.EventHandler(this.Form_HapusPost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Logout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkMember;
        private System.Windows.Forms.FlowLayoutPanel Layout;
        private System.Windows.Forms.LinkLabel linkOrderan;
    }
}