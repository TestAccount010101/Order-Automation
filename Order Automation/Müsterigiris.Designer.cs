
namespace Order_Automation
{
    partial class Müsterigiris
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
            this.TxtKullanici = new System.Windows.Forms.TextBox();
            this.TxtKpass = new System.Windows.Forms.TextBox();
            this.Btn_Mgiris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // TxtKullanici
            // 
            this.TxtKullanici.Location = new System.Drawing.Point(179, 65);
            this.TxtKullanici.Name = "TxtKullanici";
            this.TxtKullanici.Size = new System.Drawing.Size(100, 22);
            this.TxtKullanici.TabIndex = 2;
            // 
            // TxtKpass
            // 
            this.TxtKpass.Location = new System.Drawing.Point(179, 103);
            this.TxtKpass.Name = "TxtKpass";
            this.TxtKpass.Size = new System.Drawing.Size(100, 22);
            this.TxtKpass.TabIndex = 3;
            // 
            // Btn_Mgiris
            // 
            this.Btn_Mgiris.Location = new System.Drawing.Point(92, 192);
            this.Btn_Mgiris.Name = "Btn_Mgiris";
            this.Btn_Mgiris.Size = new System.Drawing.Size(153, 77);
            this.Btn_Mgiris.TabIndex = 4;
            this.Btn_Mgiris.Text = "Giriş";
            this.Btn_Mgiris.UseVisualStyleBackColor = true;
            this.Btn_Mgiris.Click += new System.EventHandler(this.Btn_Mgiris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // Müsterigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Mgiris);
            this.Controls.Add(this.TxtKpass);
            this.Controls.Add(this.TxtKullanici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Müsterigiris";
            this.Text = "müsterigrs";
            this.Load += new System.EventHandler(this.Müsterigiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullanici;
        private System.Windows.Forms.TextBox TxtKpass;
        private System.Windows.Forms.Button Btn_Mgiris;
        private System.Windows.Forms.Label label3;
    }
}