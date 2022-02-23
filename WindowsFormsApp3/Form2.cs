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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //koleksiyon tanımla
        public List<string> musteriler = new List<string>();
        private void musteriGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //müsteri girişi
            Form3 form3 = new Form3(musteriler);
            //this form2 demektir
            form3.MdiParent = this;
            form3.Show();
            //form3.ShowDialog();


        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form4 form4 = new Form4(musteriler);
            //this form2 demektir
            form4.MdiParent = this;
            form4.Show();
            //form4.ShowDialog();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
