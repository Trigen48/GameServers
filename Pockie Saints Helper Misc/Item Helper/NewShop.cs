using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{
    public partial class NewShop : Form
    {
        private bool got = false;
        public NewShop(string name,int number)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            got = true;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ShowDialog(Control control)
        {
            base.ShowDialog(control);
            return got;
        }

        public string GetName
        {
            get
            {
                return txtShpeName.Text.Trim();
            }
        }
        public int getId
        {
            get
            {
                return (int)IntID.Value;
            }
        }
    }
}
