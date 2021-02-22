using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_ToolKit_by_Kassius
{
    public partial class adminacc : Form
    {
        public adminacc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage.cmdstr = "net user administrator / active:no";
            homepage.cmdrun();
            MessageBox.Show("Default administrator account successfully disabled.\nPlease restart your computer.", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            homepage.cmdstr = "net user administrator / active:yes";
            homepage.cmdrun();
            MessageBox.Show("Default administrator account successfully enabled.\nPlease restart your computer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
