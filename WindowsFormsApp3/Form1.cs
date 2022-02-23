using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //2 satır 3 sutunluk bir kullanıcı dizisi tanımlamış
        //kullanıcı dizisi tanımladım
        string[,] kullanicilar = new string[2, 3];

        //form yüklendiginde calısacak olay kısımdır
        private void Form1_Load(object sender, EventArgs e)
        {
            //tanımlanmış kullanıcılar dizisinin içini kullanıcı kayıtlarıyla doldurdum
            //id
            kullanicilar[0, 0] = "1";
            //kullanıcıadı
            kullanicilar[0, 1] = "serdar";

            //sifre
            kullanicilar[0, 2] = "333";
            kullanicilar[1, 0] = "2";
            kullanicilar[1, 1] = "gizem";
            kullanicilar[1, 2] = "444";

        }

        //giriş butonu
        private void button1_Click(object sender, EventArgs e)
        {

            bool dogru = false;
            //Getlength 0 olursa satır 1 olursa sutun
            for (int i = 0; i < kullanicilar.GetLength(0); i++)
            {
                if ((kullanicilar[i,1]==textBox1.Text) && (kullanicilar[i,2]==textBox2.Text))
                {
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.WindowState = FormWindowState.Maximized;
                    form2.Show();
                    dogru = true;
                    //continue
                    break;
                }
            }
            if (!dogru)
            {
                MessageBox.Show("yanlış kullanıcı girdiniz tekrar deneyiniz");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Select();
            }

        }
    }
}
