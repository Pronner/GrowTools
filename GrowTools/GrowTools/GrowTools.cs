using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GrowTools
{
    public partial class GrowTools : Form
    {


        // Defining Variables

        public string xampp = "C:\\xampp\\htdocs\\growtopia";
        public string xampp1 = "C:\\xampp";

        public GrowTools()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start(label2.Text);
        }

        private void GrowTools_Load(object sender, EventArgs e)
        {

            pnMainTools.Hide();


        }

        private void pnHostNMaint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdvancedTools_Click(object sender, EventArgs e)
        {

            pnMainTools.Show();
            pnMainTools.BringToFront();

        }

        private void btnStartup_Click(object sender, EventArgs e)
        {

            pnMainTools.Show();
            pnMainTools.BringToFront();

        }

        private void pnMainTools_Paint(object sender, PaintEventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            pnMainTools.Hide();


        }

        int setup;

        private void btnStartMaintenance_Click(object sender, EventArgs e)
        {
            if (btnStartMaintenance.Text == "Stop")
            {

                if (!Directory.Exists(this.xampp))
                {


                    MessageBox.Show("Make sure to setup your GTPS Before performing this action.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setup = 0;

                }
                else
                {


                    File.WriteAllText(this.xampp + "\\server_data.php", File.ReadAllText(this.xampp + "\\server_data.php").Replace("maint|", "#maint|"));

                    MessageBox.Show("Maintenance Mode off.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setup = 1;

                    btnStartMaintenance.Text = "Start";

                }

            }
            else
            {


                if (!Directory.Exists(this.xampp))
                {


                    MessageBox.Show("Make sure to setup your GTPS Before performing this action.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setup = 0;

                }
                else
                {


                    File.WriteAllText(this.xampp + "\\server_data.php", File.ReadAllText(this.xampp + "\\server_data.php").Replace("#maint|", "maint|"));

                    MessageBox.Show("Maintenance Mode on.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setup = 1;

                    btnStartMaintenance.Text = "Stop";

                }


            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (btnStartServer.Text == "Start")
            {

                if (!File.Exists(tbStartIP.Text))
                {


                    MessageBox.Show("Couldn't find" + tbAutoIP.Text + ", please verify the location of the server executable.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (File.Exists(@"loop.bat") != true)
                {
                    using (StreamWriter loopWriter = new StreamWriter(@"loop.bat", false))
                    {
                        loopWriter.WriteLine("@echo off");
                        loopWriter.WriteLine(":loop");
                        loopWriter.WriteLine("start /w " + tbStartIP.Text);
                        loopWriter.WriteLine("goto loop");
                        loopWriter.Close();
                    }
                    Process.Start(@"loop.bat");

                    btnStartServer.Text = "Stop";
                }
                else
                {

                    Process.Start(@"loop.bat");

                    btnStartServer.Text = "Stop";

                }

            }
            else
            {

                foreach (Process process in Process.GetProcessesByName(tbStartIP.Text))
                {
                    process.Kill();


                    MessageBox.Show("Server is now set as offline.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnStartServer.Text = "Start";

                }

            }
        }

        private void btnCreateHosts_Click(object sender, EventArgs e)
        {

            using (StreamWriter hostsWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\hosts.txt", false))
            {
                hostsWriter.WriteLine(this.tbHostsIP.Text + " growtopia1.com");
                hostsWriter.WriteLine(this.tbHostsIP.Text + " growtopia2.com");
                hostsWriter.Close();

                MessageBox.Show("Server Hosts created.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public string Path1 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        private void btnStartAutoSetup_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(tbAutoIP.Text))
            {
                MessageBox.Show("You forgot to set the IP.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(tbAutoPort.Text))
            {
                MessageBox.Show("You forgot to set the Port.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Directory.CreateDirectory(Path1 + "\\AppData\\Local\\Temp\\gtpstools");
                string path = Path1 + "AppData\\Local\\Temp\\gtpstools";
                if (Directory.Exists(path))
                {
                    using (StreamWriter streamWriter = new StreamWriter(path + "serverip.txt", false))
                    {
                        streamWriter.WriteLine(tbAutoIP.Text);
                        streamWriter.Close();
                    }
                    using (StreamWriter streamWriter = new StreamWriter(path + "serverport.txt", false))
                    {
                        streamWriter.WriteLine(tbAutoPort.Text);
                        streamWriter.Close();
                    }
                }
                Process process1 = new Process();
                string str1 = "netsh.exe";
                process1.StartInfo.Arguments = "Advfirewall set privateprofile state off";
                process1.StartInfo.FileName = str1;
                process1.StartInfo.UseShellExecute = false;
                process1.StartInfo.RedirectStandardOutput = true;
                process1.StartInfo.CreateNoWindow = true;
                process1.Start();
                process1.WaitForExit();
                Process process2 = new Process();
                string str2 = "netsh.exe";
                process2.StartInfo.Arguments = "Advfirewall set publicprofile state off";
                process2.StartInfo.FileName = str2;
                process2.StartInfo.UseShellExecute = false;
                process2.StartInfo.RedirectStandardOutput = true;
                process2.StartInfo.CreateNoWindow = true;
                process2.Start();
                process2.WaitForExit();
                Process process3 = new Process();
                string str3 = "netsh.exe";
                process3.StartInfo.Arguments = "firewall add portopening TCP 80 80";
                process3.StartInfo.FileName = str3;
                process3.StartInfo.UseShellExecute = false;
                process3.StartInfo.RedirectStandardOutput = true;
                process3.StartInfo.CreateNoWindow = true;
                process3.Start();
                process3.WaitForExit();
                Process process4 = new Process();
                string str4 = "netsh.exe";
                process3.StartInfo.Arguments = "firewall add portopening TCP " + tbAutoPort.Text + " " + this.tbAutoPort.Text;
                process3.StartInfo.FileName = str4;
                process3.StartInfo.UseShellExecute = false;
                process3.StartInfo.RedirectStandardOutput = true;
                process3.StartInfo.CreateNoWindow = true;
                process3.Start();
                process3.WaitForExit();
                if (!Directory.Exists(this.xampp1))
                {

                    MessageBox.Show("XAMPP Not found. Please install it before continuing this setup.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    if (tbMaintenance.Text != "")
                    {

                        Directory.CreateDirectory(@"C:\\xampp\\htdocs\\growtopia");
                        using (StreamWriter streamWriter = new StreamWriter(this.xampp + "\\server_data.php", false))
                        {
                            streamWriter.WriteLine("server|" + tbAutoIP.Text);
                            streamWriter.WriteLine("port|" + tbAutoPort.Text);
                            streamWriter.WriteLine("type|1");
                            streamWriter.WriteLine("#maint|" + tbMaintenance.Text);
                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("beta_server|127.0.0.1");
                            streamWriter.WriteLine("beta_port|17091");
                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("beta_type|1");
                            streamWriter.WriteLine("meta|localhost");
                            streamWriter.WriteLine("RTENDMARKERBS1001");
                            streamWriter.Close();
                            MessageBox.Show("Your server has been set. Enjoy.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {

                        Directory.CreateDirectory(@"C:\\xampp\\htdocs\\growtopia");
                        using (StreamWriter streamWriter = new StreamWriter(this.xampp + "\\server_data.php", false))
                        {
                            streamWriter.WriteLine("server|" + tbAutoIP.Text);
                            streamWriter.WriteLine("port|" + tbAutoPort.Text);
                            streamWriter.WriteLine("type|1");
                            streamWriter.WriteLine("#maint|Maintenance Message");
                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("beta_server|127.0.0.1");
                            streamWriter.WriteLine("beta_port|17091");
                            streamWriter.WriteLine("");
                            streamWriter.WriteLine("beta_type|1");
                            streamWriter.WriteLine("meta|localhost");
                            streamWriter.WriteLine("RTENDMARKERBS1001");
                            streamWriter.Close();
                            MessageBox.Show("Your server has been set. Enjoy.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }


        }

        private void btnAutoRestart_Click(object sender, EventArgs e)
        {


            if (btnAutoRestart.Text == "Enable")
            {

                if (File.Exists(@"loop.bat") != true)
                {
                    using (StreamWriter loopWriter = new StreamWriter(@"loop.bat", false))
                    {
                        loopWriter.WriteLine("@echo off");
                        loopWriter.WriteLine(":loop");
                        loopWriter.WriteLine("start /w " + tbStartIP.Text);
                        loopWriter.WriteLine("goto loop");
                        loopWriter.Close();
                    }
                    Process.Start(@"loop.bat");

                    btnAutoRestart.Text = "Disable";
                }
                else
                {

                    Process.Start(@"loop.bat");

                    btnAutoRestart.Text = "Disable";

                }

            }
            else
            {



            }


        }

        private void btnHackTools_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This feature is currently under development.", "GrowTools", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
