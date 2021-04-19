
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridScreen)).BeginInit();
            this.grpBakiyeOnay.SuspendLayout();
            this.grpStokOnay.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.btnKullanicilar.FlatAppearance.BorderSize = 0;
            this.btnKullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanicilar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKullanicilar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKullanicilar.Image = global::WindowsFormsApp1.Properties.Resources.users;
            this.btnKullanicilar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKullanicilar.Location = new System.Drawing.Point(12, 223);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(173, 56);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKullanicilar.UseVisualStyleBackColor = false;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.btnBakiye.FlatAppearance.BorderSize = 0;
            this.btnBakiye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakiye.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBakiye.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBakiye.Location = new System.Drawing.Point(773, 223);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(242, 56);
            this.btnBakiye.TabIndex = 1;
            this.btnBakiye.Text = "Bekleyen Bakiye Onayları";
            this.btnBakiye.UseVisualStyleBackColor = false;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click_1);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.btnStok.FlatAppearance.BorderSize = 0;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStok.Location = new System.Drawing.Point(542, 222);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(225, 56);
            this.btnStok.TabIndex = 2;
            this.btnStok.Text = "Bekleyen Stok Onayları";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // DataGridScreen
            // 
            this.DataGridScreen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridScreen.Location = new System.Drawing.Point(12, 284);
            this.DataGridScreen.Name = "DataGridScreen";
            this.DataGridScreen.RowHeadersWidth = 51;
            this.DataGridScreen.RowTemplate.Height = 25;
            this.DataGridScreen.Size = new System.Drawing.Size(1003, 395);
            this.DataGridScreen.TabIndex = 3;
            this.DataGridScreen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridScreen_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 28);
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
            this.grpBakiyeOnay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBakiyeOnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(134)))), ((int)(((byte)(48)))));
            this.grpBakiyeOnay.Location = new System.Drawing.Point(12, 685);
            this.grpBakiyeOnay.Name = "grpBakiyeOnay";
            this.grpBakiyeOnay.Size = new System.Drawing.Size(502, 228);
            this.grpBakiyeOnay.TabIndex = 5;
            this.grpBakiyeOnay.TabStop = false;
            this.grpBakiyeOnay.Text = "Bakiye Onay";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(266, 66);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(34, 28);
            this.lblKullaniciAdi.TabIndex = 8;
            this.lblKullaniciAdi.Text = "ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad Soyad:";
            // 
            // lblEklenecekBakiye
            // 
            this.lblEklenecekBakiye.AutoSize = true;
            this.lblEklenecekBakiye.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEklenecekBakiye.ForeColor = System.Drawing.Color.Black;
            this.lblEklenecekBakiye.Location = new System.Drawing.Point(266, 121);
            this.lblEklenecekBakiye.Name = "lblEklenecekBakiye";
            this.lblEklenecekBakiye.Size = new System.Drawing.Size(65, 28);
            this.lblEklenecekBakiye.TabIndex = 6;
            this.lblEklenecekBakiye.Text = "label2";
            // 
            // btnBakiyeOnayla
            // 
            this.btnBakiyeOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.btnBakiyeOnayla.FlatAppearance.BorderSize = 0;
            this.btnBakiyeOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakiyeOnayla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBakiyeOnayla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBakiyeOnayla.Location = new System.Drawing.Point(388, 182);
            this.btnBakiyeOnayla.Name = "btnBakiyeOnayla";
            this.btnBakiyeOnayla.Size = new System.Drawing.Size(108, 40);
            this.btnBakiyeOnayla.TabIndex = 5;
            this.btnBakiyeOnayla.Text = "Onay";
            this.btnBakiyeOnayla.UseVisualStyleBackColor = false;
            this.btnBakiyeOnayla.Click += new System.EventHandler(this.btnBakiyeOnayla_Click);
            // 
            // grpStokOnay
            // 
            this.grpStokOnay.Controls.Add(this.lblKullaniciAdi2);
            this.grpStokOnay.Controls.Add(this.label5);
            this.grpStokOnay.Controls.Add(this.lblEklenecekStok);
            this.grpStokOnay.Controls.Add(this.btnStokOnayla);
            this.grpStokOnay.Controls.Add(this.label3);
            this.grpStokOnay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpStokOnay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(134)))), ((int)(((byte)(48)))));
            this.grpStokOnay.Location = new System.Drawing.Point(525, 685);
            this.grpStokOnay.Name = "grpStokOnay";
            this.grpStokOnay.Size = new System.Drawing.Size(490, 228);
            this.grpStokOnay.TabIndex = 7;
            this.grpStokOnay.TabStop = false;
            this.grpStokOnay.Text = "Stok Onay";
            // 
            // lblKullaniciAdi2
            // 
            this.lblKullaniciAdi2.AutoSize = true;
            this.lblKullaniciAdi2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullaniciAdi2.ForeColor = System.Drawing.Color.Black;
            this.lblKullaniciAdi2.Location = new System.Drawing.Point(269, 66);
            this.lblKullaniciAdi2.Name = "lblKullaniciAdi2";
            this.lblKullaniciAdi2.Size = new System.Drawing.Size(34, 28);
            this.lblKullaniciAdi2.TabIndex = 10;
            this.lblKullaniciAdi2.Text = "ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(117, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ad Soyad:";
            // 
            // lblEklenecekStok
            // 
            this.lblEklenecekStok.AutoSize = true;
            this.lblEklenecekStok.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEklenecekStok.ForeColor = System.Drawing.Color.Black;
            this.lblEklenecekStok.Location = new System.Drawing.Point(269, 121);
            this.lblEklenecekStok.Name = "lblEklenecekStok";
            this.lblEklenecekStok.Size = new System.Drawing.Size(65, 28);
            this.lblEklenecekStok.TabIndex = 6;
            this.lblEklenecekStok.Text = "label2";
            // 
            // btnStokOnayla
            // 
            this.btnStokOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.btnStokOnayla.FlatAppearance.BorderSize = 0;
            this.btnStokOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokOnayla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStokOnayla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStokOnayla.Location = new System.Drawing.Point(376, 182);
            this.btnStokOnayla.Name = "btnStokOnayla";
            this.btnStokOnayla.Size = new System.Drawing.Size(108, 40);
            this.btnStokOnayla.TabIndex = 5;
            this.btnStokOnayla.Text = "Onay";
            this.btnStokOnayla.UseVisualStyleBackColor = false;
            this.btnStokOnayla.Click += new System.EventHandler(this.btnStokOnayla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(69, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eklenecek stok: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(174)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 196);
            this.panel1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(476, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yönetici";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.login_icon_3058;
            this.pictureBox1.Location = new System.Drawing.Point(370, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1024, 925);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}