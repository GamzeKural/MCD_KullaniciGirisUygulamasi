
namespace MCD_KullaniciGirisUygulamasi
{
    partial class Form1
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
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAd.Location = new System.Drawing.Point(80, 94);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(94, 17);
            this.lblKullaniciAd.TabIndex = 0;
            this.lblKullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(80, 134);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 17);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(215, 88);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(100, 23);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Enter += new System.EventHandler(this.txtKullaniciAdi_Enter);
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(215, 131);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(100, 23);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(215, 170);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(100, 43);
            this.btnGirisYap.TabIndex = 4;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAd);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
    }
}

