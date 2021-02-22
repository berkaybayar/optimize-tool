using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Windows_ToolKit_by_Kassius
{
    public partial class homepage : Form
    {
        enum RecycleFlags : int
        {
            SHRB_NOCONFIRMATION = 0x00000001, // Don't ask for confirmation
            SHRB_NOPROGRESSUI = 0x00000001, // Don't show progress
            SHRB_NOSOUND = 0x00000004 // Don't make sound when the action is executed
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        string curdir = Directory.GetCurrentDirectory();
        public homepage()
        {
            InitializeComponent();
        }
        string thisuser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string path;
        public static string tooldocdir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\OptimizeTool";
        public static string regdir = tooldocdir + "\\curreg.reg";
        public static string bindir = tooldocdir + "\\opexecute.exe";

        String line;
        public static string cmdstr;
        public static void cmdrun()//runs cmd command 
        {
            //before calling this method define the command string in "cmdstr"
            //you can add messagebox afterwards

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(cmdstr);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
        }
        void delfile()
        {

            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                try
                {

                    file.Delete();
                }
                catch
                {
                    continue;
                }
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch
                {
                    continue;
                }
            }
        }


        void toolcreatedoc()
        {

            try
            {

            }
            catch
            {
                File.Delete(homepage.regdir);
                if (Directory.Exists(tooldocdir)) return;

                else
                {
                    Directory.CreateDirectory(tooldocdir);//creates the tool file directory

                    StreamWriter sw = new StreamWriter(tooldocdir + "\\uppcmd.txt"); //creates ultimate battery plan check file
                    sw.WriteLine("0");
                    sw.Close();
                }
            



            }

        }


        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult dellogs = new DialogResult();
            dellogs = MessageBox.Show("This action will delete logs, records of this tool only recommended if you will uninstall this tool\nTotal size < 50KB", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dellogs == DialogResult.Yes)
            {
                path = Environment.ExpandEnvironmentVariables(tooldocdir);
                delfile();
                MessageBox.Show("Files of this tool successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {


        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.computerbase.de/downloads/systemtools/all-in-one-runtimes/");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            UnlockerFrm cntfrm = new UnlockerFrm();
            cntfrm.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/microsoft/PowerToys/releases/download/v0.31.2/PowerToysSetup-0.31.2-x64.exe");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            DupeGuru dg = new DupeGuru();
            dg.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ContactForm cnt = new ContactForm();
            cnt.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cleanmgr.exe"); 
        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

            path = Environment.ExpandEnvironmentVariables("C:\\Windows\\Temp");
            delfile();

            path = Environment.ExpandEnvironmentVariables(thisuser + "\\AppData\\Local\\Temp");
            delfile();
            MessageBox.Show("Temporary system files has been deleted!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            path = Environment.ExpandEnvironmentVariables(thisuser + "\\Downloads");
            delfile();
            MessageBox.Show("Download folder hsa been cleared!");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                // Execute the method with the required parameters
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                MessageBox.Show("Recycle bin has been cleared!");
            }
            catch
            {
                // Handle exceptions
                MessageBox.Show("The recycle bin couldn't be recycled", "Clear recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }



        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            path = Environment.ExpandEnvironmentVariables(@"C:\Windows.old");
            File.Delete(path);

            MessageBox.Show("Useless system files has been deleted!");
            
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            toolcreatedoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            winpv wpv = new winpv();
            wpv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminacc adfrm = new adminacc();
            adfrm.Show();
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            try
            {
                path = Environment.ExpandEnvironmentVariables(@"C:\Windows\Prefetch");
                File.Delete(path);
                MessageBox.Show("Prefetch files successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("This tool does not have the permission to delete these files instead tool will open the file directory and you can delete files that not being used currently.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Diagnostics.Process.Start(@"C:\Windows\Prefetch");
            }

        }
        
        private void button4_Click(object sender, EventArgs e)
        {


            string uppcmdstr = tooldocdir + "\\uppcmd.txt";
            StreamReader sr = new StreamReader(uppcmdstr);
            line = sr.ReadLine();
            sr.Close();
            if (line == "1")
            {
                MessageBox.Show("This battery plan already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    //runs cmd command and enable ultimate battery plan
                    cmdstr = "powercfg -duplicatescheme e9a42b02-d5df-448d-aa00-03f14749eb61";
                    cmdrun();

                    StreamWriter sw = new StreamWriter(uppcmdstr);
                    sw.WriteLine("1");
                    sw.Close();

                    MessageBox.Show("Ultimate performance battery plan successfully enabled and visible.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex);
                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(regdir);
                File.WriteAllText(regdir, OptimizeTool.Properties.Resources.disablefullscreenopt);
                System.Diagnostics.Process.Start(regdir);

            }
            catch
            {

            }

        }



        private void button15_Click(object sender, EventArgs e)
        {

            try
            {
                File.Delete(regdir);
                File.WriteAllText(regdir, OptimizeTool.Properties.Resources.disablegamebar);
                System.Diagnostics.Process.Start(regdir);

            }
            catch
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            try
            {
                File.Delete(regdir);
                File.WriteAllText(regdir, OptimizeTool.Properties.Resources.disablebackgroungapps);  //creates the disable full screen opt file
                System.Diagnostics.Process.Start(regdir);

            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            winseced winsecfrm = new winseced();
            winsecfrm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added soon!");
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added soon!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be added soon!");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(regdir);
                File.WriteAllText(regdir, OptimizeTool.Properties.Resources.mmcsstweaks); //applies mmcss tweaks
                System.Diagnostics.Process.Start(regdir);
            }
            catch
            {

            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hexedit hexfrm = new hexedit();
            hexfrm.Show();
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Wu10Man is allows you to uninstall windows apps and configure windows updates.");
            System.Diagnostics.Process.Start("https://github.com/WereDev/Wu10Man/releases");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            dynamicticked dnfrm = new dynamicticked();
            dnfrm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hpetfrm hpeted = new hpetfrm();
            hpeted.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            syntimer syfrm = new syntimer();
            syfrm.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(regdir);
                File.WriteAllText(regdir, OptimizeTool.Properties.Resources.disablediagteleserv);
                System.Diagnostics.Process.Start(regdir);

            }
            catch
            {

            }
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(regdir);
                File.WriteAllText(regdir, OptimizeTool.Properties.Resources.disableprefetch);
                System.Diagnostics.Process.Start(regdir);

            }
            catch
            {

            }
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            performancepanel.Location= new Point(169, 10);
            performancepanel.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            File.Delete(bindir);
            File.WriteAllBytes(bindir, OptimizeTool.Properties.Resources.WinTimerTester);
            System.Diagnostics.Process.Start(bindir);
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            takeownership takefrm = new takeownership();
            takefrm.Show();
        }
    }
}
