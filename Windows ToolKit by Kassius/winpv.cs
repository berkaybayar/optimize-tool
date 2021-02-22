using System;
using System.IO;
using System.Windows.Forms;

namespace Windows_ToolKit_by_Kassius
{
    public partial class winpv : Form
    {
        public winpv()
        {
            InitializeComponent();
        }

        private void winpv_Load(object sender, EventArgs e)
        {

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
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources.disablephotoviewer);
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
                File.WriteAllText(homepage.regdir, OptimizeTool.Properties.Resources.enablephotoviewer);
                System.Diagnostics.Process.Start(homepage.regdir);
            }
            catch
            {

            }
        }
    }
}
