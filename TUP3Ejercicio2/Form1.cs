﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUP3Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textLastName.Text = "";
            textBirthPlace.Text = "";
            if (radioBtnYes.Checked)
            {
                radioBtnYes.Checked = false;
            }
            if (radioBtnNo.Checked)
            {
                radioBtnNo.Checked = false;
            }
            cBCountry.Text = "";
        }
    }
}
