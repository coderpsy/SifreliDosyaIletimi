using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace bitirme1
{
    public partial class send_file : Form
    {
        public send_file()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosec = new OpenFileDialog();
            if (dosec.ShowDialog() == DialogResult.OK)

            {
                textBox_dosyaekle.Text = dosec.FileName.ToString();
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //host ve port
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                MailMessage msg = new MailMessage();
                string gonderenmail = gonderen_mail.Text;
                string gonderensifre = gonderen_sifre.Text;
                client.Credentials = new NetworkCredential(gonderenmail, gonderensifre); //gonderenin gmail kullanici adi ve sifresi
                msg.To.Add(textBox_kime.Text);
                msg.From = new MailAddress(gonderenmail);
                msg.Subject = textBox_konu.Text;
                msg.Body = textBox_mesaj.Text;
                Attachment data = new Attachment(textBox_dosyaekle.Text);
                msg.Attachments.Add(data);
                client.Send(msg);
                MessageBox.Show("mesaj gonderme basarili");
            }


            catch (Exception ex)
            {
                if (textBox_dosyaekle.Text == "")
                {
                    MessageBox.Show("lutfen dosya seçiniz");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
