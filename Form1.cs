using System;
using System.Windows.Forms;

namespace MD5Pwd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox9.Text = MD5Util.GetMD5Hash(textBox8.Text);
        }
    }
}
