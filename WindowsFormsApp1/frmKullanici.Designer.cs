
namespace WindowsFormsApp1
{
    partial class frmKullanici
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
            this.grpKullaniciBilgileri = new System.Windows.Forms.GroupBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKullaniciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKullaniciBilgileri
            // 
            this.grpKullaniciBilgileri.Controls.Add(this.lblBakiye);
            this.grpKullaniciBilgileri.Controls.Add(this.lblAdSoyad);
            this.grpKullaniciBilgileri.Controls.Add(this.label2);
            this.grpKullaniciBilgileri.Controls.Add(this.label1);
            this.grpKullaniciBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpKullaniciBilgileri.Name = "grpKullaniciBilgileri";
            this.grpKullaniciBilgileri.Size = new System.Drawing.Size(313, 105);
            this.grpKullaniciBilgileri.TabIndex = 0;
            this.grpKullaniciBilgileri.TabStop = false;
            this.grpKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(98, 68);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(30, 25);
            this.lblBakiye.TabIndex = 3;
            this.lblBakiye.Text = "??";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(98, 39);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(108, 25);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "kullaniciadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bakiye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 629);
            this.Controls.Add(this.grpKullaniciBilgileri);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmKullanici";
            this.Text = "Kullanıcı Formu";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            this.grpKullaniciBilgileri.ResumeLayout(false);
            this.grpKullaniciBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKullaniciBilgileri;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}