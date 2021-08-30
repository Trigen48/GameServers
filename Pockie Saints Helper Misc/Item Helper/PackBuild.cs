using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{
    public partial class PackBuild : Form
    {
        string Datas;
        public PackBuild(String Data)
        {
            InitializeComponent();
            txtData.Text = Data;
            Datas = Data;
        }

        private void PackBuild_Load(object sender, EventArgs e)
        {

        }

        public string[] GetLines
        {
            get
            {
                return txtData.Lines;
            }
        }
        bool ok = false;
        public bool ShowDialog(Control c)
        {
            base.ShowDialog(c);

            return ok;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ok = true;
            Datas = txtData.Text;
            this.Close();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Splits();
        }

        public void Splits()
        {    
            if (txtData.Lines.Length == 1)
            {
                string ex = txtData.Text;
                const string cc = "Contains: ";
                const string cx="Open to get: ";
                if (ex.StartsWith(cc))
                {
                    ex = ex.Remove(0, cc.Length);

                    string[] lines = ex.Split(",".ToCharArray());

                    for (int x = 0; x < lines.Length; x++)
                    {
                        lines[x] = lines[x].Trim(" ".ToCharArray());
                    }
                    txtData.Lines = lines;
                }
                else
                {
                    if (ex.StartsWith(cx))
                    {
                        ex = ex.Remove(0, cx.Length);

                        string[] lines = ex.Split(",".ToCharArray());

                        for (int x = 0; x < lines.Length; x++)
                        {
                            lines[x] = lines[x].Trim(" ".ToCharArray());
                        }
                        txtData.Lines = lines;
                    }
                }
            }
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            txtData.Text = Datas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Splits();
            ok = true;
            Datas = txtData.Text;
            this.Close();

        }
    }
}
