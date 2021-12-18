
namespace Order_Automation
{
    partial class Müsterikayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.Txt_Kullaniciad = new System.Windows.Forms.TextBox();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.BtnKydt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtsifre = new System.Windows.Forms.TextBox();
            this.TxtsifreTekrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(133, 46);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(138, 22);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(133, 85);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(138, 22);
            this.TxtSoyad.TabIndex = 2;
            // 
            // Txt_Kullaniciad
            // 
            this.Txt_Kullaniciad.Location = new System.Drawing.Point(133, 124);
            this.Txt_Kullaniciad.Name = "Txt_Kullaniciad";
            this.Txt_Kullaniciad.Size = new System.Drawing.Size(138, 22);
            this.Txt_Kullaniciad.TabIndex = 3;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(77, 243);
            this.TxtAdres.Multiline = true;
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(194, 88);
            this.TxtAdres.TabIndex = 6;
            // 
            // BtnKydt
            // 
            this.BtnKydt.Location = new System.Drawing.Point(143, 360);
            this.BtnKydt.Name = "BtnKydt";
            this.BtnKydt.Size = new System.Drawing.Size(128, 29);
            this.BtnKydt.TabIndex = 7;
            this.BtnKydt.Text = "Kaydet";
            this.BtnKydt.UseVisualStyleBackColor = true;
            this.BtnKydt.Click += new System.EventHandler(this.BtnKydt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şiifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şifre tekrarı";
            // 
            // Txtsifre
            // 
            this.Txtsifre.Location = new System.Drawing.Point(133, 163);
            this.Txtsifre.Name = "Txtsifre";
            this.Txtsifre.Size = new System.Drawing.Size(138, 22);
            this.Txtsifre.TabIndex = 4;
            // 
            // TxtsifreTekrar
            // 
            this.TxtsifreTekrar.Location = new System.Drawing.Point(133, 202);
            this.TxtsifreTekrar.Name = "TxtsifreTekrar";
            this.TxtsifreTekrar.Size = new System.Drawing.Size(138, 22);
            this.TxtsifreTekrar.TabIndex = 5;
            // 
            // Müsterikayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.TxtsifreTekrar);
            this.Controls.Add(this.Txtsifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnKydt);
            this.Controls.Add(this.TxtAdres);
            this.Controls.Add(this.Txt_Kullaniciad);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Müsterikayit";
            this.Text = "Müşteri Kayıt ";
            this.Load += new System.EventHandler(this.Müsterikayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox Txt_Kullaniciad;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Button BtnKydt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtsifre;
        private System.Windows.Forms.TextBox TxtsifreTekrar;
    }
}