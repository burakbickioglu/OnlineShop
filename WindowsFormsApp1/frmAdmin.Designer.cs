﻿
namespace WindowsFormsApp1
{
    partial class frmAdmin
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
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.DataGridScreen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBakiyeOnay = new System.Windows.Forms.GroupBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEklenecekBakiye = new System.Windows.Forms.Label();
            this.btnBakiyeOnayla = new System.Windows.Forms.Button();
            this.grpStokOnay = new System.Windows.Forms.GroupBox();
            this.lblKullaniciAdi2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEklenecekStok = new System.Windows.Forms.Label();
            this.btnStokOnayla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridScreen)).BeginInit();
            this.grpBakiyeOnay.SuspendLayout();
            this.grpStokOnay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Location = new System.Drawing.Point(12, 12);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(166, 49);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.Location = new System.Drawing.Point(12, 84);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(166, 66);
            this.btnBakiye.TabIndex = 1;
            this.btnBakiye.Text = "Bekleyen Bakiye Onayları";
            this.btnBakiye.UseVisualStyleBackColor = true;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click_1);
            // 
            // btnStok
            // 
            this.btnStok.Location = new System.Drawing.Point(12, 173);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(166, 66);
            this.btnStok.TabIndex = 2;
            this.btnStok.Text = "Bekleyen Stok Onayları";
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // DataGridScreen
            // 
            this.DataGridScreen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridScreen.Location = new System.Drawing.Point(227, 12);
            this.DataGridScreen.Name = "DataGridScreen";
            this.DataGridScreen.RowHeadersWidth = 51;
            this.DataGridScreen.RowTemplate.Height = 25;
            this.DataGridScreen.Size = new System.Drawing.Size(971, 378);
            this.DataGridScreen.TabIndex = 3;
            this.DataGridScreen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridScreen_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eklenecek tutar: ";
            // 
            // grpBakiyeOnay
            // 
            this.grpBakiyeOnay.Controls.Add(this.lblKullaniciAdi);
            this.grpBakiyeOnay.Controls.Add(this.label2);
            this.grpBakiyeOnay.Controls.Add(this.lblEklenecekBakiye);
            this.grpBakiyeOnay.Controls.Add(this.btnBakiyeOnayla);
            this.grpBakiyeOnay.Controls.Add(this.label1);
            this.grpBakiyeOnay.Location = new System.Drawing.Point(209, 416);
            this.grpBakiyeOnay.Name = "grpBakiyeOnay";
            this.grpBakiyeOnay.Size = new System.Drawing.Size(490, 168);
            this.grpBakiyeOnay.TabIndex = 5;
            this.grpBakiyeOnay.TabStop = false;
            this.grpBakiyeOnay.Text = "Bakiye Onay";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(161, 44);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(40, 32);
            this.lblKullaniciAdi.TabIndex = 8;
            this.lblKullaniciAdi.Text = "ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad Soyad:";
            // 
            // lblEklenecekBakiye
            // 
            this.lblEklenecekBakiye.AutoSize = true;
            this.lblEklenecekBakiye.Location = new System.Drawing.Point(161, 69);
            this.lblEklenecekBakiye.Name = "lblEklenecekBakiye";
            this.lblEklenecekBakiye.Size = new System.Drawing.Size(78, 32);
            this.lblEklenecekBakiye.TabIndex = 6;
            this.lblEklenecekBakiye.Text = "label2";
            // 
            // btnBakiyeOnayla
            // 
            this.btnBakiyeOnayla.Location = new System.Drawing.Point(380, 124);
            this.btnBakiyeOnayla.Name = "btnBakiyeOnayla";
            this.btnBakiyeOnayla.Size = new System.Drawing.Size(104, 38);
            this.btnBakiyeOnayla.TabIndex = 5;
            this.btnBakiyeOnayla.Text = "Onay";
            this.btnBakiyeOnayla.UseVisualStyleBackColor = true;
            this.btnBakiyeOnayla.Click += new System.EventHandler(this.btnBakiyeOnayla_Click);
            // 
            // grpStokOnay
            // 
            this.grpStokOnay.Controls.Add(this.lblKullaniciAdi2);
            this.grpStokOnay.Controls.Add(this.label5);
            this.grpStokOnay.Controls.Add(this.lblEklenecekStok);
            this.grpStokOnay.Controls.Add(this.btnStokOnayla);
            this.grpStokOnay.Controls.Add(this.label3);
            this.grpStokOnay.Location = new System.Drawing.Point(724, 416);
            this.grpStokOnay.Name = "grpStokOnay";
            this.grpStokOnay.Size = new System.Drawing.Size(490, 168);
            this.grpStokOnay.TabIndex = 7;
            this.grpStokOnay.TabStop = false;
            this.grpStokOnay.Text = "Stok Onay";
            // 
            // lblKullaniciAdi2
            // 
            this.lblKullaniciAdi2.AutoSize = true;
            this.lblKullaniciAdi2.Location = new System.Drawing.Point(155, 29);
            this.lblKullaniciAdi2.Name = "lblKullaniciAdi2";
            this.lblKullaniciAdi2.Size = new System.Drawing.Size(40, 32);
            this.lblKullaniciAdi2.TabIndex = 10;
            this.lblKullaniciAdi2.Text = "ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ad Soyad:";
            // 
            // lblEklenecekStok
            // 
            this.lblEklenecekStok.AutoSize = true;
            this.lblEklenecekStok.Location = new System.Drawing.Point(155, 69);
            this.lblEklenecekStok.Name = "lblEklenecekStok";
            this.lblEklenecekStok.Size = new System.Drawing.Size(78, 32);
            this.lblEklenecekStok.TabIndex = 6;
            this.lblEklenecekStok.Text = "label2";
            // 
            // btnStokOnayla
            // 
            this.btnStokOnayla.Location = new System.Drawing.Point(380, 124);
            this.btnStokOnayla.Name = "btnStokOnayla";
            this.btnStokOnayla.Size = new System.Drawing.Size(104, 38);
            this.btnStokOnayla.TabIndex = 5;
            this.btnStokOnayla.Text = "Onay";
            this.btnStokOnayla.UseVisualStyleBackColor = true;
            this.btnStokOnayla.Click += new System.EventHandler(this.btnStokOnayla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eklenecek stok: ";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1226, 596);
            this.Controls.Add(this.grpStokOnay);
            this.Controls.Add(this.grpBakiyeOnay);
            this.Controls.Add(this.DataGridScreen);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnBakiye);
            this.Controls.Add(this.btnKullanicilar);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridScreen)).EndInit();
            this.grpBakiyeOnay.ResumeLayout(false);
            this.grpBakiyeOnay.PerformLayout();
            this.grpStokOnay.ResumeLayout(false);
            this.grpStokOnay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgKullanicilar;
        private System.Windows.Forms.DataGridView DataGridScreen;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBakiyeOnay;
        private System.Windows.Forms.Label lblEklenecekBakiye;
        private System.Windows.Forms.Button btnBakiyeOnayla;
        private System.Windows.Forms.GroupBox grpStokOnay;
        private System.Windows.Forms.Label lblEklenecekStok;
        private System.Windows.Forms.Button btnStokOnayla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKullaniciAdi2;
        private System.Windows.Forms.Label label5;
    }
}