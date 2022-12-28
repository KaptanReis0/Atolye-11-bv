using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adam_asmaca_kaan_bilge_çıracı_ödev
{
    public partial class Form1 : Form
    {
        int hak = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = "BOKSÖR";
            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Harf Girin");
            }
            else
            {
                if (textBox1.Text == kelime[0].ToString())
                {
                    label1.Text = "B";
                }
                else
                {
                    if (textBox1.Text == kelime[1].ToString())
                    {
                        label2.Text = "O";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[2].ToString())
                        {
                            label3.Text = "K";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[3].ToString())
                            {
                                label4.Text = "S";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[4].ToString())
                                {
                                    label5.Text = "Ö";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime[5].ToString())
                                    {
                                        label6.Text = "R";
                                    }
                                    else
                                    {
                                        hak++;
                                        if (hak == 1)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\1.png";
                                        }
                                        else if (hak == 2)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\2.png";
                                        }
                                        else if (hak == 3)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\3.png";
                                        }
                                        else if (hak == 4)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\4.png";
                                        }
                                        else if (hak == 5)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\5.png";
                                        }
                                        else if (hak == 6)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\6.png";
                                            button1.Enabled = false;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("Oyunu Kaybettiniz!");
                                            MessageBox.Show("BOKSÖR", "Cevap");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (label1.Text == "B")
            {
                if (label2.Text == "O")
                {
                    if (label3.Text == "K")
                    {
                        if (label4.Text == "S")
                        {
                            if (label5.Text == "Ö")
                            {
                                if (label6.Text == "R")
                                {
                                    button3.Enabled = false;
                                    textBox1.Enabled = false;
                                    button2.Visible = true;


                                }
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label8.Text = "Bu Bir Spordur Bu Sporu Yapan Kişiye Denir Dövüş Sporudur";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
            label4.Text = "-";
            label5.Text = "-";
            label6.Text = "-";
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button3.Enabled = true;
            label8.Text = "Bu Bir Balık Türüdür Akdeniz Ve Karadeniz De Bulunur 20 25 Cm Arası Boyları Vardır";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime = "MEZGİT";
            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Harf Giriniz");
            }
            else
            {
                if (textBox1.Text == kelime[0].ToString())
                {
                    label1.Text = "M";
                }
                else
                {
                    if (textBox1.Text == kelime[1].ToString())
                    {
                        label2.Text = "E";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[2].ToString())
                        {
                            label3.Text = "Z";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[3].ToString())
                            {
                                label4.Text = "G";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[4].ToString())
                                {
                                    label5.Text = "İ";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime[5].ToString())
                                    {
                                        label6.Text = "T";
                                    }
                                    else
                                    {
                                        hak++;
                                        if (hak == 1)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\1.png";
                                        }
                                        else if (hak == 2)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\2.png";
                                        }
                                        else if (hak == 3)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\3.png";
                                        }
                                        else if (hak == 4)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\4.png";
                                        }
                                        else if (hak == 5)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\5.png";
                                        }
                                        else if (hak == 6)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\6.png";
                                            button3.Enabled = false;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("Oyunu Kaybettiniz!");
                                            MessageBox.Show("MEZGİT", "Cevap");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (label1.Text == "M")
            {
                if (label2.Text == "E")
                {
                    if (label3.Text == "Z")
                    {
                        if (label4.Text == "G")
                        {
                            if (label5.Text == "İ")
                            {
                                if (label6.Text == "T")
                                {
                                    button1.Enabled = false;
                                    textBox1.Enabled = false;
                                    button2.Visible = false;
                                    button4.Visible = true;

                                }
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
            label4.Text = "-";
            label5.Text = "-";
            label6.Text = "-";
            textBox1.Text = "";
            textBox1.Enabled = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            label8.Text = "Bu Da Bir Hayvandır Ama Karada Yaşar Ve Vahşidir Büyük İhtimal Sadece Hayvanat Bahçesinde Gördünüz";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string kelime = "TİMSAH";
            textBox1.Text = textBox1.Text.ToUpper();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Harf Giriniz");
            }
            else
            {
                if (textBox1.Text == kelime[0].ToString())
                {
                    label1.Text = "T";
                }
                else
                {
                    if (textBox1.Text == kelime[1].ToString())
                    {
                        label2.Text = "İ";
                    }
                    else
                    {
                        if (textBox1.Text == kelime[2].ToString())
                        {
                            label3.Text = "M";
                        }
                        else
                        {
                            if (textBox1.Text == kelime[3].ToString())
                            {
                                label4.Text = "S";
                            }
                            else
                            {
                                if (textBox1.Text == kelime[4].ToString())
                                {
                                    label5.Text = "A";
                                }
                                else
                                {
                                    if (textBox1.Text == kelime[5].ToString())
                                    {
                                        label6.Text = "H";
                                    }
                                    else
                                    {
                                        hak++;
                                        if (hak == 1)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\1.png";
                                        }
                                        else if (hak == 2)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\2.png";
                                        }
                                        else if (hak == 3)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\3.png";
                                        }
                                        else if (hak == 4)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\4.png";
                                        }
                                        else if (hak == 5)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\5.png";
                                        }
                                        else if (hak == 6)
                                        {
                                            pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Desktop\\adam asmaca\\6.png";
                                            button5.Enabled = false;
                                            textBox1.Enabled = false;
                                            MessageBox.Show("Oyunu Kaybettiniz!");
                                            MessageBox.Show("TİMSAH", "Cevap");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (label1.Text == "T")
            {
                if (label2.Text == "İ")
                {
                    if (label3.Text == "M")
                    {
                        if (label4.Text == "S")
                        {
                            if (label5.Text == "A")
                            {
                                if (label6.Text == "H")
                                {
                                    MessageBox.Show("Oyunu Kazandın");
                                    button1.Enabled = false;
                                    textBox1.Enabled = false;
                                    button4.Visible = false;
                                    button5.Enabled = false;
                                    Form1 yeni = new Form1();
                                    yeni.Close();


                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
        
    
    
    

