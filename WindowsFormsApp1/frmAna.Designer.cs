
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
            this.SuspendLayout();
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciGiris.Location = new System.Drawing.Point(12, 12);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(222, 52);
            this.btnKullaniciGiris.TabIndex = 0;
            this.btnKullaniciGiris.Text = "Kullanıcı Girişi";
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGiris.Location = new System.Drawing.Point(12, 79);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(222, 52);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "Admin Girişi";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeOl.Location = new System.Drawing.Point(12, 146);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(222, 52);
            this.btnUyeOl.TabIndex = 2;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = true;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(247, 214);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnUyeOl;
    }
}

