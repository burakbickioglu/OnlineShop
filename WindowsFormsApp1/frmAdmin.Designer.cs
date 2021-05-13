
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnKullanicilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.btnKullanicilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnKullanicilar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKullanicilar.FlatAppearance.BorderSize = 0;
            this.btnKullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullanicilar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKullanicilar.ForeColor = System.Drawing.Color.White;
            this.btnKullanicilar.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanicilar.Image")));
            this.btnKullanicilar.Location = new System.Drawing.Point(12, 5);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(124, 120);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKullanicilar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnKullanicilar.UseVisualStyleBackColor = false;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.btnBakiye.FlatAppearance.BorderSize = 0;
            this.btnBakiye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakiye.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBakiye.ForeColor = System.Drawing.Color.White;
            this.btnBakiye.Image = ((System.Drawing.Image)(resources.GetObject("btnBakiye.Image")));
            this.btnBakiye.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBakiye.Location = new System.Drawing.Point(12, 133);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(124, 120);
            this.btnBakiye.TabIndex = 1;
            this.btnBakiye.Text = "Bakiye";
            this.btnBakiye.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBakiye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBakiye.UseVisualStyleBackColor = false;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click_1);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.btnStok.FlatAppearance.BorderSize = 0;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStok.ForeColor = System.Drawing.Color.White;
            this.btnStok.Image = ((System.Drawing.Image)(resources.GetObject("btnStok.Image")));
            this.btnStok.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStok.Location = new System.Drawing.Point(12, 261);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(124, 120);
            this.btnStok.TabIndex = 2;
            this.btnStok.Text = "Stok";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // DataGridScreen
            // 
            this.DataGridScreen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridScreen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.DataGridScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridScreen.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridScreen.Location = new System.Drawing.Point(144, 5);
            this.DataGridScreen.Name = "DataGridScreen";
            this.DataGridScreen.RowHeadersVisible = false;
            this.DataGridScreen.RowTemplate.Height = 25;
            this.DataGridScreen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGridScreen.Size = new System.Drawing.Size(998, 378);
            this.DataGridScreen.TabIndex = 3;
            this.DataGridScreen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridScreen_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eklenecek tutar: ";
            // 
            // grpBakiyeOnay
            // 
            this.grpBakiyeOnay.BackColor = System.Drawing.Color.Transparent;
            this.grpBakiyeOnay.Controls.Add(this.lblKullaniciAdi);
            this.grpBakiyeOnay.Controls.Add(this.label2);
            this.grpBakiyeOnay.Controls.Add(this.lblEklenecekBakiye);
            this.grpBakiyeOnay.Controls.Add(this.btnBakiyeOnayla);
            this.grpBakiyeOnay.Controls.Add(this.label1);
            this.grpBakiyeOnay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpBakiyeOnay.Location = new System.Drawing.Point(144, 389);
            this.grpBakiyeOnay.Name = "grpBakiyeOnay";
            this.grpBakiyeOnay.Size = new System.Drawing.Size(410, 168);
            this.grpBakiyeOnay.TabIndex = 5;
            this.grpBakiyeOnay.TabStop = false;
            this.grpBakiyeOnay.Text = "Bakiye Onay";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(160, 44);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(34, 25);
            this.lblKullaniciAdi.TabIndex = 8;
            this.lblKullaniciAdi.Text = "ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(59, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad Soyad:";
            // 
            // lblEklenecekBakiye
            // 
            this.lblEklenecekBakiye.AutoSize = true;
            this.lblEklenecekBakiye.Location = new System.Drawing.Point(160, 69);
            this.lblEklenecekBakiye.Name = "lblEklenecekBakiye";
            this.lblEklenecekBakiye.Size = new System.Drawing.Size(65, 25);
            this.lblEklenecekBakiye.TabIndex = 6;
            this.lblEklenecekBakiye.Text = "label2";
            // 
            // btnBakiyeOnayla
            // 
            this.btnBakiyeOnayla.BackColor = System.Drawing.Color.Transparent;
            this.btnBakiyeOnayla.FlatAppearance.BorderSize = 0;
            this.btnBakiyeOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBakiyeOnayla.Image = ((System.Drawing.Image)(resources.GetObject("btnBakiyeOnayla.Image")));
            this.btnBakiyeOnayla.Location = new System.Drawing.Point(308, 69);
            this.btnBakiyeOnayla.Name = "btnBakiyeOnayla";
            this.btnBakiyeOnayla.Size = new System.Drawing.Size(96, 96);
            this.btnBakiyeOnayla.TabIndex = 5;
            this.btnBakiyeOnayla.UseVisualStyleBackColor = false;
            this.btnBakiyeOnayla.Click += new System.EventHandler(this.btnBakiyeOnayla_Click);
            // 
            // grpStokOnay
            // 
            this.grpStokOnay.BackColor = System.Drawing.Color.Transparent;
            this.grpStokOnay.Controls.Add(this.lblKullaniciAdi2);
            this.grpStokOnay.Controls.Add(this.label5);
            this.grpStokOnay.Controls.Add(this.lblEklenecekStok);
            this.grpStokOnay.Controls.Add(this.btnStokOnayla);
            this.grpStokOnay.Controls.Add(this.label3);
            this.grpStokOnay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpStokOnay.Location = new System.Drawing.Point(144, 389);
            this.grpStokOnay.Name = "grpStokOnay";
            this.grpStokOnay.Size = new System.Drawing.Size(410, 168);
            this.grpStokOnay.TabIndex = 7;
            this.grpStokOnay.TabStop = false;
            this.grpStokOnay.Text = "Stok Onay";
            // 
            // lblKullaniciAdi2
            // 
            this.lblKullaniciAdi2.AutoSize = true;
            this.lblKullaniciAdi2.Location = new System.Drawing.Point(154, 44);
            this.lblKullaniciAdi2.Name = "lblKullaniciAdi2";
            this.lblKullaniciAdi2.Size = new System.Drawing.Size(34, 25);
            this.lblKullaniciAdi2.TabIndex = 10;
            this.lblKullaniciAdi2.Text = "ad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ad Soyad:";
            // 
            // lblEklenecekStok
            // 
            this.lblEklenecekStok.AutoSize = true;
            this.lblEklenecekStok.Location = new System.Drawing.Point(154, 69);
            this.lblEklenecekStok.Name = "lblEklenecekStok";
            this.lblEklenecekStok.Size = new System.Drawing.Size(65, 25);
            this.lblEklenecekStok.TabIndex = 6;
            this.lblEklenecekStok.Text = "label2";
            // 
            // btnStokOnayla
            // 
            this.btnStokOnayla.BackColor = System.Drawing.Color.Transparent;
            this.btnStokOnayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStokOnayla.BackgroundImage")));
            this.btnStokOnayla.FlatAppearance.BorderSize = 0;
            this.btnStokOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokOnayla.Location = new System.Drawing.Point(308, 69);
            this.btnStokOnayla.Name = "btnStokOnayla";
            this.btnStokOnayla.Size = new System.Drawing.Size(96, 96);
            this.btnStokOnayla.TabIndex = 5;
            this.btnStokOnayla.UseVisualStyleBackColor = false;
            this.btnStokOnayla.Click += new System.EventHandler(this.btnStokOnayla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eklenecek stok: ";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1145, 569);
            this.Controls.Add(this.grpStokOnay);
            this.Controls.Add(this.grpBakiyeOnay);
            this.Controls.Add(this.DataGridScreen);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.btnBakiye);
            this.Controls.Add(this.btnKullanicilar);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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