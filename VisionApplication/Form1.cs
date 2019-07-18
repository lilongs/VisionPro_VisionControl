using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisionApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set the title of this application using the title supplied in the generated control
            this.Text = visionControl1.ApplicationName;
        }

        private void FormClosingHandler(object sender, FormClosingEventArgs e)
        {
            visionControl1.Close();
        }   

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}