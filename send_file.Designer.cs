namespace bitirme1
{
    partial class send_file
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
            this.textBox_kime = new System.Windows.Forms.TextBox();
            this.textBox_konu = new System.Windows.Forms.TextBox();
            this.textBox_mesaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dosyaekle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gonderen_mail = new System.Windows.Forms.TextBox();
            this.gonderen_sifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesaj";
            // 
            // textBox_kime
            // 
            this.textBox_kime.Location = new System.Drawing.Point(118, 67);
            this.textBox_kime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_kime.Name = "textBox_kime";
            this.textBox_kime.Size = new System.Drawing.Size(200, 20);
            this.textBox_kime.TabIndex = 4;
            // 
            // textBox_konu
            // 
            this.textBox_konu.Location = new System.Drawing.Point(118, 98);
            this.textBox_konu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_konu.Name = "textBox_konu";
            this.textBox_konu.Size = new System.Drawing.Size(200, 20);
            this.textBox_konu.TabIndex = 5;
            this.textBox_konu.Text = "RsaKey";
            // 
            // textBox_mesaj
            // 
            this.textBox_mesaj.Location = new System.Drawing.Point(118, 132);
            this.textBox_mesaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_mesaj.Multiline = true;
            this.textBox_mesaj.Name = "textBox_mesaj";
            this.textBox_mesaj.Size = new System.Drawing.Size(200, 19);
            this.textBox_mesaj.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dosya Ekleme";
            // 
            // textBox_dosyaekle
            // 
            this.textBox_dosyaekle.Location = new System.Drawing.Point(118, 164);
            this.textBox_dosyaekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_dosyaekle.Name = "textBox_dosyaekle";
            this.textBox_dosyaekle.Size = new System.Drawing.Size(200, 20);
            this.textBox_dosyaekle.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 188);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dosya Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gonderen_mail
            // 
            this.gonderen_mail.Location = new System.Drawing.Point(118, 11);
            this.gonderen_mail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gonderen_mail.Name = "gonderen_mail";
            this.gonderen_mail.Size = new System.Drawing.Size(200, 20);
            this.gonderen_mail.TabIndex = 10;
            // 
            // gonderen_sifre
            // 
            this.gonderen_sifre.Location = new System.Drawing.Point(118, 37);
            this.gonderen_sifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gonderen_sifre.Name = "gonderen_sifre";
            this.gonderen_sifre.Size = new System.Drawing.Size(200, 20);
            this.gonderen_sifre.TabIndex = 11;
            this.gonderen_sifre.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "gonderen mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "gonderen sifre";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(243, 229);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "Gönder";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // send_file
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 344);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gonderen_sifre);
            this.Controls.Add(this.gonderen_mail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_dosyaekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_mesaj);
            this.Controls.Add(this.textBox_konu);
            this.Controls.Add(this.textBox_kime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "send_file";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_kime;
        private System.Windows.Forms.TextBox textBox_konu;
        private System.Windows.Forms.TextBox textBox_mesaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dosyaekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox gonderen_mail;
        private System.Windows.Forms.TextBox gonderen_sifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_send;
    }
}

