
namespace WindowsFormsApp1
{
    partial class frmBakiyeEkle
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
            this.btnIstekGonder = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIstekGonder
            // 
            this.btnIstekGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.btnIstekGonder.FlatAppearance.BorderSize = 0;
            this.btnIstekGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIstekGonder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIstekGonder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIstekGonder.Location = new System.Drawing.Point(185, 285);
            this.btnIstekGonder.Name = "btnIstekGonder";
            this.btnIstekGonder.Size = new System.Drawing.Size(121, 31);
            this.btnIstekGonder.TabIndex = 7;
            this.btnIstekGonder.Text = "İstek Gönder";
            this.btnIstekGonder.UseVisualStyleBackColor = false;
            this.btnIstekGonder.Click += new System.EventHandler(this.btnIstekGonder_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTutar.Location = new System.Drawing.Point(185, 232);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(158, 32);
            this.txtTutar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(134)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(185, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tutar:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(190)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 155);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(242, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bakiye Ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.add_wallet_1853738_15726282;
            this.pictureBox1.Location = new System.Drawing.Point(126, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmBakiyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIstekGonder);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmBakiyeEkle";
            this.Text = "Bakiye Ekle";
            this.Load += new System.EventHandler(this.frmBakiyeEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIstekGonder;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}