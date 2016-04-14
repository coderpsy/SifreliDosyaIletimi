namespace bitirme1
{
    partial class keyCreator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_4096bit = new System.Windows.Forms.CheckBox();
            this.chk_2048bit = new System.Windows.Forms.CheckBox();
            this.chk_1024bit = new System.Windows.Forms.CheckBox();
            this.chk_512bit = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_4096bit);
            this.groupBox1.Controls.Add(this.chk_2048bit);
            this.groupBox1.Controls.Add(this.chk_1024bit);
            this.groupBox1.Controls.Add(this.chk_512bit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anahtar Uzunluğu";
            // 
            // chk_4096bit
            // 
            this.chk_4096bit.AutoSize = true;
            this.chk_4096bit.Location = new System.Drawing.Point(128, 72);
            this.chk_4096bit.Name = "chk_4096bit";
            this.chk_4096bit.Size = new System.Drawing.Size(65, 17);
            this.chk_4096bit.TabIndex = 5;
            this.chk_4096bit.Text = "4096 Bit";
            this.chk_4096bit.UseVisualStyleBackColor = true;
            // 
            // chk_2048bit
            // 
            this.chk_2048bit.AutoSize = true;
            this.chk_2048bit.Location = new System.Drawing.Point(12, 72);
            this.chk_2048bit.Name = "chk_2048bit";
            this.chk_2048bit.Size = new System.Drawing.Size(65, 17);
            this.chk_2048bit.TabIndex = 4;
            this.chk_2048bit.Text = "2048 Bit";
            this.chk_2048bit.UseVisualStyleBackColor = true;
            // 
            // chk_1024bit
            // 
            this.chk_1024bit.AutoSize = true;
            this.chk_1024bit.Location = new System.Drawing.Point(128, 31);
            this.chk_1024bit.Name = "chk_1024bit";
            this.chk_1024bit.Size = new System.Drawing.Size(65, 17);
            this.chk_1024bit.TabIndex = 3;
            this.chk_1024bit.Text = "1024 Bit";
            this.chk_1024bit.UseVisualStyleBackColor = true;
            // 
            // chk_512bit
            // 
            this.chk_512bit.AutoSize = true;
            this.chk_512bit.Location = new System.Drawing.Point(12, 31);
            this.chk_512bit.Name = "chk_512bit";
            this.chk_512bit.Size = new System.Drawing.Size(59, 17);
            this.chk_512bit.TabIndex = 2;
            this.chk_512bit.Text = "512 Bit";
            this.chk_512bit.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(12, 227);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(193, 46);
            this.btn_create.TabIndex = 8;
            this.btn_create.Text = "Tamam";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 83);
            this.label1.TabIndex = 9;
            this.label1.Text = "Üretmek istediğiniz anahtar uzunluklarını işaretleyip Tamam\'a basınız.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keyCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "keyCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anahtar";
            this.Load += new System.EventHandler(this.keyCreator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.CheckBox chk_2048bit;
        private System.Windows.Forms.CheckBox chk_1024bit;
        private System.Windows.Forms.CheckBox chk_512bit;
        private System.Windows.Forms.CheckBox chk_4096bit;
        private System.Windows.Forms.Label label1;
    }
}