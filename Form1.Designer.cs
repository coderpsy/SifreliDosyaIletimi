namespace bitirme1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_getfile = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btn_xorcreate = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rdbtn_8bit = new System.Windows.Forms.RadioButton();
            this.rdbtn_16bit = new System.Windows.Forms.RadioButton();
            this.rdbtn_32bit = new System.Windows.Forms.RadioButton();
            this.rdbtn_64bit = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_keyolustur = new System.Windows.Forms.Button();
            this.btn_dec = new System.Windows.Forms.Button();
            this.btn_xorkeysec = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_getfile
            // 
            this.btn_getfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_getfile.Location = new System.Drawing.Point(21, 30);
            this.btn_getfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_getfile.Name = "btn_getfile";
            this.btn_getfile.Size = new System.Drawing.Size(372, 127);
            this.btn_getfile.TabIndex = 2;
            this.btn_getfile.Text = "Dosya Şifrele/Çöz";
            this.btn_getfile.UseVisualStyleBackColor = true;
            this.btn_getfile.Click += new System.EventHandler(this.btn_getfile_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(221, 31);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(221, 62);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 17);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btn_xorcreate
            // 
            this.btn_xorcreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xorcreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_xorcreate.Location = new System.Drawing.Point(5, 23);
            this.btn_xorcreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xorcreate.Name = "btn_xorcreate";
            this.btn_xorcreate.Size = new System.Drawing.Size(227, 43);
            this.btn_xorcreate.TabIndex = 11;
            this.btn_xorcreate.Text = "XOR Anahtar Oluştur";
            this.btn_xorcreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xorcreate.UseVisualStyleBackColor = true;
            this.btn_xorcreate.Click += new System.EventHandler(this.btn_enc_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(141, 422);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(616, 28);
            this.progressBar1.TabIndex = 14;
            // 
            // rdbtn_8bit
            // 
            this.rdbtn_8bit.AutoSize = true;
            this.rdbtn_8bit.Location = new System.Drawing.Point(13, 74);
            this.rdbtn_8bit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_8bit.Name = "rdbtn_8bit";
            this.rdbtn_8bit.Size = new System.Drawing.Size(56, 21);
            this.rdbtn_8bit.TabIndex = 15;
            this.rdbtn_8bit.TabStop = true;
            this.rdbtn_8bit.Text = "8 bit";
            this.rdbtn_8bit.UseVisualStyleBackColor = true;
            // 
            // rdbtn_16bit
            // 
            this.rdbtn_16bit.AutoSize = true;
            this.rdbtn_16bit.Location = new System.Drawing.Point(131, 70);
            this.rdbtn_16bit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_16bit.Name = "rdbtn_16bit";
            this.rdbtn_16bit.Size = new System.Drawing.Size(64, 21);
            this.rdbtn_16bit.TabIndex = 16;
            this.rdbtn_16bit.TabStop = true;
            this.rdbtn_16bit.Text = "16 bit";
            this.rdbtn_16bit.UseVisualStyleBackColor = true;
            // 
            // rdbtn_32bit
            // 
            this.rdbtn_32bit.AutoSize = true;
            this.rdbtn_32bit.Location = new System.Drawing.Point(13, 113);
            this.rdbtn_32bit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_32bit.Name = "rdbtn_32bit";
            this.rdbtn_32bit.Size = new System.Drawing.Size(64, 21);
            this.rdbtn_32bit.TabIndex = 17;
            this.rdbtn_32bit.TabStop = true;
            this.rdbtn_32bit.Text = "32 bit";
            this.rdbtn_32bit.UseVisualStyleBackColor = true;
            // 
            // rdbtn_64bit
            // 
            this.rdbtn_64bit.AutoSize = true;
            this.rdbtn_64bit.Location = new System.Drawing.Point(131, 111);
            this.rdbtn_64bit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_64bit.Name = "rdbtn_64bit";
            this.rdbtn_64bit.Size = new System.Drawing.Size(64, 21);
            this.rdbtn_64bit.TabIndex = 18;
            this.rdbtn_64bit.TabStop = true;
            this.rdbtn_64bit.Text = "64 bit";
            this.rdbtn_64bit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtn_8bit);
            this.groupBox1.Controls.Add(this.rdbtn_64bit);
            this.groupBox1.Controls.Add(this.rdbtn_16bit);
            this.groupBox1.Controls.Add(this.rdbtn_32bit);
            this.groupBox1.Controls.Add(this.btn_xorcreate);
            this.groupBox1.Location = new System.Drawing.Point(401, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(236, 142);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seçilen XOR Anahtarı            :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Seçilen RSA Public Anahtarı  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Seçilen RSA Private Anahtarı : ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(221, 86);
            this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(72, 17);
            this.linkLabel3.TabIndex = 23;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.linkLabel3);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(21, 240);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(843, 123);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // btn_keyolustur
            // 
            this.btn_keyolustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_keyolustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_keyolustur.Location = new System.Drawing.Point(645, 38);
            this.btn_keyolustur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_keyolustur.Name = "btn_keyolustur";
            this.btn_keyolustur.Size = new System.Drawing.Size(227, 43);
            this.btn_keyolustur.TabIndex = 10;
            this.btn_keyolustur.Text = "RSA Anahtarı Oluştur";
            this.btn_keyolustur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_keyolustur.UseVisualStyleBackColor = true;
            this.btn_keyolustur.Click += new System.EventHandler(this.btn_keyolustur_Click);
            // 
            // btn_dec
            // 
            this.btn_dec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dec.Location = new System.Drawing.Point(645, 139);
            this.btn_dec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(227, 43);
            this.btn_dec.TabIndex = 12;
            this.btn_dec.Text = "XOR Çöz";
            this.btn_dec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dec.UseVisualStyleBackColor = true;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // btn_xorkeysec
            // 
            this.btn_xorkeysec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xorkeysec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_xorkeysec.Location = new System.Drawing.Point(645, 89);
            this.btn_xorkeysec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xorkeysec.Name = "btn_xorkeysec";
            this.btn_xorkeysec.Size = new System.Drawing.Size(227, 43);
            this.btn_xorkeysec.TabIndex = 13;
            this.btn_xorkeysec.Text = "XOR Anahtarı Seç";
            this.btn_xorkeysec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xorkeysec.UseVisualStyleBackColor = true;
            this.btn_xorkeysec.Click += new System.EventHandler(this.btn_xorkeysec_Click);
            // 
            // btn_send
            // 
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_send.Location = new System.Drawing.Point(645, 190);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(227, 43);
            this.btn_send.TabIndex = 25;
            this.btn_send.Text = "Gönder";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 476);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_xorkeysec);
            this.Controls.Add(this.btn_dec);
            this.Controls.Add(this.btn_keyolustur);
            this.Controls.Add(this.btn_getfile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cryptology";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_getfile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btn_xorcreate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rdbtn_8bit;
        private System.Windows.Forms.RadioButton rdbtn_16bit;
        private System.Windows.Forms.RadioButton rdbtn_32bit;
        private System.Windows.Forms.RadioButton rdbtn_64bit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_keyolustur;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.Button btn_xorkeysec;
        private System.Windows.Forms.Button btn_send;
    }
}

