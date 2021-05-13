
namespace WindowsFormsApp1
{
    partial class frmStokEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cmbEklenecekUrun = new System.Windows.Forms.ComboBox();
            this.btnIstekGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMiktar.Location = new System.Drawing.Point(89, 70);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(121, 27);
            this.txtMiktar.TabIndex = 2;
            // 
            // cmbEklenecekUrun
            // 
            this.cmbEklenecekUrun.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEklenecekUrun.FormattingEnabled = true;
            this.cmbEklenecekUrun.Location = new System.Drawing.Point(89, 18);
            this.cmbEklenecekUrun.Name = "cmbEklenecekUrun";
            this.cmbEklenecekUrun.Size = new System.Drawing.Size(121, 28);
            this.cmbEklenecekUrun.TabIndex = 3;
            // 
            // btnIstekGonder
            // 
            this.btnIstekGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(105)))), ((int)(((byte)(136)))));
            this.btnIstekGonder.FlatAppearance.BorderSize = 0;
            this.btnIstekGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstekGonder.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIstekGonder.ForeColor = System.Drawing.Color.White;
            this.btnIstekGonder.Location = new System.Drawing.Point(89, 117);
            this.btnIstekGonder.Name = "btnIstekGonder";
            this.btnIstekGonder.Size = new System.Drawing.Size(121, 35);
            this.btnIstekGonder.TabIndex = 4;
            this.btnIstekGonder.Text = "İstek Gönder";
            this.btnIstekGonder.UseVisualStyleBackColor = false;
            this.btnIstekGonder.Click += new System.EventHandler(this.btnIstekGonder_Click);
            // 
            // frmStokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(168)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(238, 188);
            this.Controls.Add(this.btnIstekGonder);
            this.Controls.Add(this.cmbEklenecekUrun);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmStokEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStokEkle";
            this.Load += new System.EventHandler(this.frmStokEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ComboBox cmbEklenecekUrun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIstekGonder;
    }
}