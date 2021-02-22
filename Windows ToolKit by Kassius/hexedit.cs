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
using OptimizeTool.Properties;

namespace Windows_ToolKit_by_Kassius
{
    public partial class hexedit : Form
    {
        public hexedit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources._25hexbalance);
                System.Diagnostics.Process.Start(homepage.regdir);

            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources._16hexsmooth);
                System.Diagnostics.Process.Start(homepage.regdir);

            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources._28hexlowest);
                System.Diagnostics.Process.Start(homepage.regdir);

            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources._26hexdefault);
                System.Diagnostics.Process.Start(homepage.regdir);

            }
            catch
            {

            }
        }
    }
}
