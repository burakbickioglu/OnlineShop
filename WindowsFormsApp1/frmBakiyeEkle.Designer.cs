
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
            this.SuspendLayout();
            // 
            // btnIstekGonder
            // 
            this.btnIstekGonder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIstekGonder.Location = new System.Drawing.Point(88, 59);
            this.btnIstekGonder.Name = "btnIstekGonder";
            this.btnIstekGonder.Size = new System.Drawing.Size(121, 35);
            this.btnIstekGonder.TabIndex = 7;
            this.btnIstekGonder.Text = "İstek Gönder";
            this.btnIstekGonder.UseVisualStyleBackColor = true;
            this.btnIstekGonder.Click += new System.EventHandler(this.btnIstekGonder_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTutar.Location = new System.Drawing.Point(88, 12);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 27);
            this.txtTutar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tutar:";
            // 
            // frmBakiyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 108);
            this.Controls.Add(this.btnIstekGonder);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmBakiyeEkle";
            this.Text = "Bakiye Ekle";
            this.Load += new System.EventHandler(this.frmBakiyeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIstekGonder;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label2;
    }
}