using System;
using System.Windows.Forms;

namespace Windows_ToolKit_by_Kassius
{
    public partial class UnlockerFrm : Form
    {
        public UnlockerFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unlocker App is allows you to delete files while they are being used also it allows you to delete system files so be careful.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://down.gezginler.net/1881-Unlockerx64_1.9.2.msi");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://down.gezginler.net/1881-Unlocker_1.9.2.msi");
            this.Close();
        }
    }
}
