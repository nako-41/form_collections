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
    public partial class Form4 : Form
    {
        public List<string> musteriler = new List<string>();

        public Form4(List<string> must1)
        {
            InitializeComponent();
            this.musteriler = must1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
             //kayıt ilerletme degişkeni y dir
            int y = 0;
            //satır bazında for döngüsü kullandık

            for (int i = 0; i < musteriler.Count() / 3; i++)
            {
                //musteriler listesindeki ad,soyad,telefon bilgilerini degiskenlere atadık
                string ad, soyad, telefon;
                ad = musteriler[i + y];
                soyad = musteriler[i + y + 1];
                telefon = musteriler[i + y + 2];
                y = y + 2;

                //satır dizisine degiskenleri attık
                string[] satır = { ad, soyad, telefon };

                //item nesnesi olusturduk satır dizisini kullanarak
                ListViewItem item = new ListViewItem(satır);

                //item nesnesinide ekrandaki listviewa ekledik
                listView1.Items.Add(item);

            }


        }
    }
}
