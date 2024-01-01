using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, doğru = 0, yanliş = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // SORULARIN CEVAP KISMI
                switch (soruno)
                {
                    // 1 SORUNUN CEVABI
                    case 1:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button5.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button6.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button7.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button8.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button9.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button10.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button11.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button12.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button13.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button14.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button15.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button16.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button17.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button18.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button19.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button20.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button21.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button22.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button23.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button24.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button25.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button25.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button2.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button3.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "(DOĞRU CEVAP)")
                        {
                            button4.BackColor = Color.Green;
                            doğru++;
                            label2.Text = doğru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanliş++;
                            label4.Text = yanliş.ToString();
                        }
                        break;



                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "CEVAPLA";
            soruno++;
            this.Text = soruno.ToString();
            // SORULAR KISMI
            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiyenin başkenti Neresidir? ";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İskenderi meşhur olan ilimiz? ";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Sigara Markası? ";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü olan şehrimiz? ";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Öğrenci şehri denildiğinde akla ilk gelen şehrimiz? ";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Sarı - Lacivert renkli futbol takımımız? ";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Deniz ulaşımında kullanılan ulaşım aracı? ";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "6 Şubat depreminde zarar gören ilimiz? ";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = " ";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = " ";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = " ";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = " ";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = " ";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = " ";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "    ";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = " ";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "    ";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = " ";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "    ";
                button23.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = " ";
                button24.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = " ";
                button25.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = " ";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = " ";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = " ";
                button4.BackColor = Color.Yellow;
            }

        }
    }
}
