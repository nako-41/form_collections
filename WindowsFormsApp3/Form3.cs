﻿using System;
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
    public partial class Form3 : Form
    {
        //koleksiyon var
        public List<string> musteriler = new List<string>();

        public Form3(List<string>must1)
        {
            InitializeComponent();
            this.musteriler = must1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriler.Add(textBox1.Text);
            musteriler.Add(textBox2.Text);
            musteriler.Add(textBox3.Text);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Select();
        }
    }
}
