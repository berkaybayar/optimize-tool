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
    public partial class syntimer : Form
    {
        public syntimer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homepage.cmdstr = "bcdedit /set useplatformtick yes";
            homepage.cmdrun();
            MessageBox.Show("Synthetic Timer successfully disabled.\nPlease restart your computer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            homepage.cmdstr = "bcdedit /deletevalue useplatformtick";
            homepage.cmdrun();
            MessageBox.Show("Synthetic Timer successfully enabled.\nPlease restart your computer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
