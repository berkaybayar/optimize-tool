using System;
using System.Windows.Forms;

namespace Windows_ToolKit_by_Kassius
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.t.me/kassius2k");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.github.com/kassius2k");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
