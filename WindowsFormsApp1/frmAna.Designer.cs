
namespace WindowsFormsApp1
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKullaniciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciGiris.Image = global::WindowsFormsApp1.Properties.Resources.user1;
            this.btnKullaniciGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKullaniciGiris.Location = new System.Drawing.Point(12, 204);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(292, 179);
            this.btnKullaniciGiris.TabIndex = 0;
            this.btnKullaniciGiris.Text = "Kullanıcı Girişi";
            this.btnKullaniciGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGiris.Image = global::WindowsFormsApp1.Properties.Resources.admin1;
            this.btnAdminGiris.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdminGiris.Location = new System.Drawing.Point(310, 204);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(292, 179);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "Admin Girişi";
            this.btnAdminGiris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeOl.Image = global::WindowsFormsApp1.Properties.Resources.multy_user;
            this.btnUyeOl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUyeOl.Location = new System.Drawing.Point(608, 204);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(292, 179);
            this.btnUyeOl.TabIndex = 2;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 197);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Online_Shopping_512;
            this.pictureBox1.Location = new System.Drawing.Point(222, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(358, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(913, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Shopping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

