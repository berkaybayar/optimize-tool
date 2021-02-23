using System;
using System.IO;
using System.Windows.Forms;

namespace Windows_ToolKit_by_Kassius
{
    public partial class winseced : Form
    {
        public winseced()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources.disablewinsec);
                System.Diagnostics.Process.Start(homepage.regdir);
                
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.Delete(homepage.regdir);
            try
            {
                File.Delete(homepage.regdir);
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources.enablewinsec);
                System.Diagnostics.Process.Start(homepage.regdir);
                
            }
            catch
            {

            }
        }

        private void winseced_Load(object sender, EventArgs e)
        {

        }

      
    }
}
