using System;
using System.Text;
using System.Windows.Forms;

namespace bitcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            tbSize.Text = (UTF8Encoding.UTF8.GetByteCount(textBoxInput.Text) * 8).ToString();
        }
    }
}
