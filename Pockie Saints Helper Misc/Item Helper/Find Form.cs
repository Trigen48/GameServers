using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{
    public partial class Find_Form : Form
    {

        bool hreassult;
      //  string ret = "";
        public Find_Form()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hreassult = true;
            this.Close();
        }

        public bool ShowDialog(Control c)
        {

            base.ShowDialog(c);
            return hreassult;
        }

        public string SearchTerm()
        {
            return textBox1.Text.Trim();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hreassult = true;
                this.Close();
            }
        }


    }
}
