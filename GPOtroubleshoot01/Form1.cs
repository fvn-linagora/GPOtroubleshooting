﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPOtroubleshoot01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey, you're up ?");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine + "Changed your mind again ?!";
        }
    }
}
