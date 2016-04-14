using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitirme1
{
    public partial class keyCreator : Form
    {
        RichTextBox textBox;
        public keyCreator(RichTextBox text)
        {
            InitializeComponent();
            textBox = text;
        }

        private void keyCreator_Load(object sender, EventArgs e)
        {
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
                rsaClass rsa = new rsaClass();

                if (chk_512bit.Checked == true)
                {
                    rsa.generateKey(512);
                }
                if (chk_1024bit.Checked == true)
                {
                    rsa.generateKey(1024);
                }
                if (chk_2048bit.Checked == true)
                {
                    rsa.generateKey(2048);
                }

                if (chk_4096bit.Checked == true)
                {
                    rsa.generateKey(4096);
                }
                MessageBox.Show("Anahtarlar oluşturuldu", " ", MessageBoxButtons.OK);
                Close();
        }
    }
}



