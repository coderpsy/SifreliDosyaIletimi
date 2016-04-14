using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace bitirme1
{
    public partial class Form1 : Form
    {
        public string dosyaYolu;
        public string sifrelemeTuru;
        public int keySize;
        public static string metatext;
        public static string text;
        byte[] byteData;
        Int64 sifre;


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_getfile.Enabled = false;
            rdbtn_64bit.Checked = true;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
        }
        private RichTextBox richTextBox3; //windowception
        
        private void btn_getfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\" + Environment.GetEnvironmentVariable("USERNAME") + "\\Desktop";
            openFileDialog1.FileName = "";

            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int k;
                int boyut = 64;  // bir seferde okunacak ve/veya yazılacak veri boyutu
               
                try
                {   //şifrelenecek dosya için filestream izinleri ayarlanıyor
                    FileStream fs_read = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                    //şifrelenen dosyanın kayıt edilmesi
                    SaveFileDialog save_file = new SaveFileDialog();
                    save_file.FileName = "";
                    save_file.InitialDirectory = "C:\\Users\\" + Environment.GetEnvironmentVariable("USERNAME") + "\\Desktop";
                    save_file.DefaultExt = Path.GetExtension(openFileDialog1.FileName);

                    if (save_file.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            double millisecondilkdeger = DateTime.Now.Ticks;  //mikrosaniye ilk deger

                            FileStream fs_write = new FileStream(save_file.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                            byteData = new byte[boyut];
                            byte[] encrypted_data = new byte[boyut];

                            //progressBar1.Maximum = (int)fs_read.Length;//
                            //int artir = (int)fs_read.Length / 100000;
                            //progressBar1.Step = artir; //progressbar'ın herbir artışı boyut kadar olacak
                            //progressBar1.Minimum = 1;
                            //progressBar1.Value = 2;

                            for (int i = 0; i < fs_read.Length; i += boyut)
                            {
                                k = 0;
                                fs_read.Read(byteData, 0, boyut);

                                while (k < boyut)
                                {
                                    encrypted_data[k] = (byte)(byteData[k] ^ sifre);
                                    k++;
                                }

                                fs_write.Write(encrypted_data, 0, boyut);

                                //progressBar1.PerformStep(); //progressbar ilerleme
                            }

                            fs_read.Close(); // şifrelemek için okunan dosya kapanıyor.
                            fs_write.Close(); // şifrelenip yazılan dosya kapanıyor.

                            double millisecondikincideger = DateTime.Now.Ticks;// mikrosaniye ikinci deger 10^-6

                            double islemsuresi = (millisecondikincideger - millisecondilkdeger) / 10000000;// saniye olarak ifade ediliyor1242124->1,24..

                            MessageBox.Show(" işlem süresi :" + islemsuresi.ToString() + "saniye", "işlem tamamlandı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        catch(Exception hata)
                        {
                            MessageBox.Show(hata.ToString());
                        }
                    }

                    else
                        return;

                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }
            }
            else
                return;
        }

        #region linklabel_click_event
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(linkLabel1.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(), "", MessageBoxButtons.OK);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(linkLabel2.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(),"", MessageBoxButtons.OK);
            }
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(linkLabel3.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString(),"", MessageBoxButtons.OK);
            }
        }

        #endregion

        private void btn_keyolustur_Click(object sender, EventArgs e)
        {
            Form keyCreator = new keyCreator(this.richTextBox3);
            keyCreator.Show();

            linkLabel2.Text = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\rsa\\publics\\");
            linkLabel3.Text = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\rsa\\privates\\");

            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
        }


        #region text e atama
        private bool writePdftrigger;
        public void writePdf(string text, string path)
        {

            if (writePdftrigger == true)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(text);
                }
            }
        }

        public void readPdf(string flnm)
        {
            text = string.Empty;
            metatext = string.Empty;


            using (StreamReader reader = new StreamReader(flnm))
            {
                text = reader.ReadToEnd();
            }

        }
        #endregion
        #region rsa_enc
        private void btn_enc_Click(object sender, EventArgs e)
        {
            int key_size = 0;
            if (rdbtn_8bit.Checked == true)
                key_size = 8;
            else if (rdbtn_16bit.Checked == true)
                key_size = 16;
            else if (rdbtn_32bit.Checked == true)
                key_size = 32;
            else if (rdbtn_64bit.Checked == true)
                key_size = 64;

            string fileString = "";
            string keyPath = "";
            Random rnd=new Random();
            for (int n = 0; n < key_size; n++)
            {
                text += rnd.Next(0, 2);
            }
            if (text.Length != 0)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Title = " Choose key";
                openFileDialog1.Filter = " ( *.pb;*.pr )|*.pb;*.pr";    //privle sifrelenmis mesajlar da olabilir o yüzden pb leride gostermesi daha mantikli

                openFileDialog1.InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\");



                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        keyPath = string.Empty;
                        dosyaYolu = keyPath = openFileDialog1.FileName;

                        fileString = string.Empty;
                        StreamReader streamReader = new StreamReader(openFileDialog1.FileName, true);
                        fileString = streamReader.ReadToEnd();
                        streamReader.Close();
                    }
                }
                else
                    return;


                sifrelemeTuru = "RSA";
                string bitStrengthString = fileString.Substring(0, fileString.IndexOf("</BitStrength>") + 14);
                fileString = fileString.Replace(bitStrengthString, "");
                int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));
                keySize = bitStrength;

                rsaClass rsa = new rsaClass();


                text = rsa.Encrypt(new object[] { text, bitStrength, fileString });

                // şifrelenen metin kaydediliyor

                if (text != null)
                {
                    try
                    {
                        Directory.CreateDirectory(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\xor_key\\encrypted\\");
                        string path = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\xor_key\\encrypted\\");

                        path += DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".enc";
                        writePdftrigger = true;
                        writePdf(text, path);
                        writePdftrigger = false;

                        MessageBox.Show("Şifrelenmiş XOR anahtarı kaydedildi.");

                    }

                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }
        }
        #endregion

        #region rsa_dec
        private void btn_dec_Click(object sender, EventArgs e)
        {
            string fileString = "";
            string keyPath = "";
            openFileDialog1.Title = " Select File";
            openFileDialog1.Filter = "ENC Document(*.enc) | *.enc";
            openFileDialog1.InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\xor_key\\encrypted\\");

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                readPdf(openFileDialog1.FileName);
                MessageBox.Show("Şifrelemede kullandığınız RSA anahtarının eşini seçiniz.");
            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

            if (text.Length != 0)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.Title = " Choose key";
                openFileDialog1.Filter = " ( *.pb;*.pr )|*.pb;*.pr";    //privle sifrelenmis mesajlar da olabilir o yüzden pb leride gostermesi daha mantikli

                openFileDialog1.InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\keys\\");



                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog1.FileName))
                    {
                        keyPath = string.Empty;
                        keyPath = openFileDialog1.FileName;

                        fileString = string.Empty;
                        StreamReader streamReader = new StreamReader(openFileDialog1.FileName, true);
                        fileString = streamReader.ReadToEnd();
                        streamReader.Close();


                    }
                }
                else
                    return;
                //rsa algoritma seçili ise rsa şifreleme yapılıyor

                string bitStrengthString = fileString.Substring(0, fileString.IndexOf("</BitStrength>") + 14);
                fileString = fileString.Replace(bitStrengthString, "");
                int bitStrength = Convert.ToInt32(bitStrengthString.Replace("<BitStrength>", "").Replace("</BitStrength>", ""));

                rsaClass rsa = new rsaClass();
                text = rsa.Decrypt(new object[] { text, bitStrength, fileString });

            }

            if (text != null)
            {
                try
                {
                    Directory.CreateDirectory(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\xor_key\\decrypted\\");
                    string path = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\xor_key\\decrypted\\");
                    path += DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt";

                    writePdftrigger = true;
                    writePdf(text, path);
                    writePdftrigger = false;


                    MessageBox.Show("Çözülen XOR anahtarı kaydedildi.");
                }

                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }

        }
        #endregion

        private void btn_xorkeysec_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Path.Combine(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + "\\xor_key\\decrypted\\");
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    linkLabel1.Visible = true;
                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName, true);
                    string fileString = streamReader.ReadToEnd();
                    streamReader.Close();

                    sifre = Convert.ToInt64(fileString, 2);
                    btn_getfile.Enabled = true;
                    linkLabel1.Text = openFileDialog1.FileName;
                 }
            }
            else
                return;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            Form send = new send_file();
            send.Show();
        }

    

     

      

    }
}

