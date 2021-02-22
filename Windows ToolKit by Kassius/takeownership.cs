using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Windows_ToolKit_by_Kassius
{
    public partial class takeownership : Form
    {
        public takeownership()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources.takeownership);
                System.Diagnostics.Process.Start(homepage.regdir);
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources.removeownership);
                System.Diagnostics.Process.Start(homepage.regdir);
            }
            catch
            {

            }
        }
    }
}
