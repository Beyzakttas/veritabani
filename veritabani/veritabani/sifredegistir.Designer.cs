namespace veritabani
{
    partial class sifredegistir
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
            this.eskisifre = new System.Windows.Forms.TextBox();
            this.yenisifre = new System.Windows.Forms.TextBox();
            this.yenitekrer = new System.Windows.Forms.TextBox();
            this.captcha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelcaptcha = new System.Windows.Forms.Label();
            this.mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eskisifre
            // 
            this.eskisifre.Location = new System.Drawing.Point(158, 62);
            this.eskisifre.Name = "eskisifre";
            this.eskisifre.Size = new System.Drawing.Size(178, 22);
            this.eskisifre.TabIndex = 0;
            // 
            // yenisifre
            // 
            this.yenisifre.Location = new System.Drawing.Point(158, 121);
            this.yenisifre.Name = "yenisifre";
            this.yenisifre.Size = new System.Drawing.Size(178, 22);
            this.yenisifre.TabIndex = 1;
            // 
            // yenitekrer
            // 
            this.yenitekrer.Location = new System.Drawing.Point(158, 171);
            this.yenitekrer.Name = "yenitekrer";
            this.yenitekrer.Size = new System.Drawing.Size(178, 22);
            this.yenitekrer.TabIndex = 2;
            // 
            // captcha
            // 
            this.captcha.Location = new System.Drawing.Point(236, 244);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(100, 22);
            this.captcha.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 57);
            this.button1.TabIndex = 4;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yeni Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yeni Şifre (Tekrar)";
            // 
            // labelcaptcha
            // 
            this.labelcaptcha.AutoSize = true;
            this.labelcaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelcaptcha.Location = new System.Drawing.Point(72, 246);
            this.labelcaptcha.Name = "labelcaptcha";
            this.labelcaptcha.Size = new System.Drawing.Size(146, 20);
            this.labelcaptcha.TabIndex = 8;
            this.labelcaptcha.Text = "Yeni Şifre (Tekrar)";
            // 
            // mesaj
            // 
            this.mesaj.AutoSize = true;
            this.mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesaj.Location = new System.Drawing.Point(54, 304);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(53, 20);
            this.mesaj.TabIndex = 9;
            this.mesaj.Text = "label5";
            // 
            // sifredegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.labelcaptcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.yenitekrer);
            this.Controls.Add(this.yenisifre);
            this.Controls.Add(this.eskisifre);
            this.Name = "sifredegistir";
            this.Text = "sifredegistir";
            this.Load += new System.EventHandler(this.sifredegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eskisifre;
        private System.Windows.Forms.TextBox yenisifre;
        private System.Windows.Forms.TextBox yenitekrer;
        private System.Windows.Forms.TextBox captcha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelcaptcha;
        private System.Windows.Forms.Label mesaj;
    }
}