
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
            this.btnBakiyeEkle = new System.Windows.Forms.Button();
            this.lblTc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDataGridYenile = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAlis = new System.Windows.Forms.Button();
            this.txtAlinacakMiktar = new System.Windows.Forms.TextBox();
            this.cmbAlinacakUrun = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.cmbSatilacakUrun = new System.Windows.Forms.ComboBox();
            this.txtSatilacakMiktar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpKullaniciBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKullaniciBilgileri
            // 
            this.grpKullaniciBilgileri.Controls.Add(this.btnBakiyeEkle);
            this.grpKullaniciBilgileri.Controls.Add(this.lblTc);
            this.grpKullaniciBilgileri.Controls.Add(this.label5);
            this.grpKullaniciBilgileri.Controls.Add(this.lblTel);
            this.grpKullaniciBilgileri.Controls.Add(this.label4);
            this.grpKullaniciBilgileri.Controls.Add(this.lblBakiye);
            this.grpKullaniciBilgileri.Controls.Add(this.lblAdSoyad);
            this.grpKullaniciBilgileri.Controls.Add(this.label2);
            this.grpKullaniciBilgileri.Controls.Add(this.label1);
            this.grpKullaniciBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpKullaniciBilgileri.Name = "grpKullaniciBilgileri";
            this.grpKullaniciBilgileri.Size = new System.Drawing.Size(260, 225);
            this.grpKullaniciBilgileri.TabIndex = 0;
            this.grpKullaniciBilgileri.TabStop = false;
            this.grpKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            // 
            // btnBakiyeEkle
            // 
            this.btnBakiyeEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBakiyeEkle.FlatAppearance.BorderSize = 0;
            this.btnBakiyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakiyeEkle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBakiyeEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBakiyeEkle.Location = new System.Drawing.Point(98, 181);
            this.btnBakiyeEkle.Name = "btnBakiyeEkle";
            this.btnBakiyeEkle.Size = new System.Drawing.Size(92, 38);
            this.btnBakiyeEkle.TabIndex = 2;
            this.btnBakiyeEkle.Text = "Bakiye Ekle";
            this.btnBakiyeEkle.UseVisualStyleBackColor = false;
            this.btnBakiyeEkle.Click += new System.EventHandler(this.btnBakiyeEkle_Click);
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTc.Location = new System.Drawing.Point(98, 113);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(56, 28);
            this.lblTc.TabIndex = 8;
            this.lblTc.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(59, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tc:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTel.Location = new System.Drawing.Point(98, 78);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(56, 28);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon: ";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBakiye.Location = new System.Drawing.Point(98, 144);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(30, 28);
            this.lblBakiye.TabIndex = 3;
            this.lblBakiye.Text = "??";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdSoyad.Location = new System.Drawing.Point(98, 44);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(110, 28);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "kullaniciadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bakiye:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDataGridYenile);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 358);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stoktaki Ürünleriniz";
            // 
            // btnDataGridYenile
            // 
            this.btnDataGridYenile.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnDataGridYenile.FlatAppearance.BorderSize = 0;
            this.btnDataGridYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataGridYenile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDataGridYenile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDataGridYenile.Location = new System.Drawing.Point(6, 38);
            this.btnDataGridYenile.Name = "btnDataGridYenile";
            this.btnDataGridYenile.Size = new System.Drawing.Size(159, 37);
            this.btnDataGridYenile.TabIndex = 2;
            this.btnDataGridYenile.Text = "Yenile";
            this.btnDataGridYenile.UseVisualStyleBackColor = false;
            this.btnDataGridYenile.Click += new System.EventHandler(this.btnDataGridYenile_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUrunEkle.Location = new System.Drawing.Point(613, 38);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(159, 37);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(772, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAlis);
            this.groupBox2.Controls.Add(this.txtAlinacakMiktar);
            this.groupBox2.Controls.Add(this.cmbAlinacakUrun);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alış Emri";
            // 
            // btnAlis
            // 
            this.btnAlis.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAlis.FlatAppearance.BorderSize = 0;
            this.btnAlis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlis.Location = new System.Drawing.Point(83, 126);
            this.btnAlis.Name = "btnAlis";
            this.btnAlis.Size = new System.Drawing.Size(133, 37);
            this.btnAlis.TabIndex = 4;
            this.btnAlis.Text = "Alım Emri";
            this.btnAlis.UseVisualStyleBackColor = false;
            this.btnAlis.Click += new System.EventHandler(this.btnAlis_Click);
            // 
            // txtAlinacakMiktar
            // 
            this.txtAlinacakMiktar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAlinacakMiktar.Location = new System.Drawing.Point(83, 78);
            this.txtAlinacakMiktar.Name = "txtAlinacakMiktar";
            this.txtAlinacakMiktar.Size = new System.Drawing.Size(133, 32);
            this.txtAlinacakMiktar.TabIndex = 7;
            // 
            // cmbAlinacakUrun
            // 
            this.cmbAlinacakUrun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAlinacakUrun.FormattingEnabled = true;
            this.cmbAlinacakUrun.Location = new System.Drawing.Point(83, 39);
            this.cmbAlinacakUrun.Name = "cmbAlinacakUrun";
            this.cmbAlinacakUrun.Size = new System.Drawing.Size(133, 33);
            this.cmbAlinacakUrun.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(7, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miktar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtBirimFiyat);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnSatis);
            this.groupBox3.Controls.Add(this.cmbSatilacakUrun);
            this.groupBox3.Controls.Add(this.txtSatilacakMiktar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(554, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 225);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Satış Emri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(30, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Fiyat:";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirimFiyat.Location = new System.Drawing.Point(84, 125);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(133, 32);
            this.txtBirimFiyat.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(30, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Birim";
            // 
            // btnSatis
            // 
            this.btnSatis.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSatis.FlatAppearance.BorderSize = 0;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSatis.Location = new System.Drawing.Point(84, 175);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(133, 36);
            this.btnSatis.TabIndex = 8;
            this.btnSatis.Text = "Satış Emri";
            this.btnSatis.UseVisualStyleBackColor = false;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // cmbSatilacakUrun
            // 
            this.cmbSatilacakUrun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSatilacakUrun.FormattingEnabled = true;
            this.cmbSatilacakUrun.Location = new System.Drawing.Point(84, 39);
            this.cmbSatilacakUrun.Name = "cmbSatilacakUrun";
            this.cmbSatilacakUrun.Size = new System.Drawing.Size(133, 33);
            this.cmbSatilacakUrun.TabIndex = 11;
            // 
            // txtSatilacakMiktar
            // 
            this.txtSatilacakMiktar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSatilacakMiktar.Location = new System.Drawing.Point(84, 81);
            this.txtSatilacakMiktar.Name = "txtSatilacakMiktar";
            this.txtSatilacakMiktar.Size = new System.Drawing.Size(133, 32);
            this.txtSatilacakMiktar.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ürün:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Miktar:";
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpKullaniciBilgileri);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Formu";
            this.Load += new System.EventHandler(this.frmKullanici_Load);
            this.grpKullaniciBilgileri.ResumeLayout(false);
            this.grpKullaniciBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKullaniciBilgileri;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAlis;
        private System.Windows.Forms.TextBox txtAlinacakMiktar;
        private System.Windows.Forms.ComboBox cmbAlinacakUrun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.ComboBox cmbSatilacakUrun;
        private System.Windows.Forms.TextBox txtSatilacakMiktar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBakiyeEkle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnDataGridYenile;
    }
}