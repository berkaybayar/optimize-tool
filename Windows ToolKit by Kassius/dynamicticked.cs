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
    public partial class dynamicticked : Form
    {
        public dynamicticked()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            homepage.cmdstr = "bcdedit /set disabledynamictick yes";
            homepage.cmdrun();
            MessageBox.Show("Dynamic Tick successfully disabled.\nPlease restart your computer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            homepage.cmdstr = "bcdedit /deletevalue disabledynamictick";
            homepage.cmdrun();
            MessageBox.Show("Dynamic Tick successfully set to default.\nPlease restart your computer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
