using System;
using System.Windows.Forms;

namespace Windows_ToolKit_by_Kassius
{
    public partial class DupeGuru : Form
    {
        public DupeGuru()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/arsenetar/dupeguru/releases/download/4.1.0/dupeGuru_win64_4.1.0.exe");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/arsenetar/dupeguru/releases/download/4.1.0/dupeGuru_win32_4.1.0.exe");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dupeGuru is a tool to find duplicate files on your computer. It can scan either filenames or contents. The filename scan features a fuzzy matching algorithm that can find duplicate filenames even when they are not exactly the same.");
        }
    }
}
