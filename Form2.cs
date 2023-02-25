using Microsoft.AspNetCore.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public static Boolean opti;
        public static Boolean mmap;
        public Form2()
        {
            InitializeComponent();
        }
        private void Textdownload(string url, string name)
        {
            WebClient webClient = new();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.DownloadProgressCallback4);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompletdCallback1);
            Uri uri = new Uri(url);
            this.label5.Text = string.Concat(Form1.path, "\\", name, ".txt");
            webClient.DownloadFileAsync(uri, string.Concat(Form1.path, "\\", name, ".txt"));
        }
        private void Filedownload(string url, string name)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.DownloadProgressCallback4);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompletdCallback1);
            Uri uri = new Uri(url);
            this.label5.Text = string.Concat(Form1.path, "\\", name, ".zip");
            webClient.DownloadFileAsync(uri, string.Concat(Form1.path, "\\", name, ".zip"));
        }
        private async void Forgedownload(string url, string name)
        {
            WebClient webClient = new();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(this.DownloadProgressCallback4);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(this.DownloadCompletdCallback1);
            Uri uri = new Uri(url);

            string name2 = WindowsIdentity.GetCurrent().Name;
            if (name2.Contains("\\"))
            {
                name2.IndexOf("\\");
                string[] strArrays = name2.Split(new char[] { Convert.ToChar("\\") });
                string name3 = strArrays[1];
                string path2 = string.Concat("C:\\Users\\", name3, "\\Downloads\\forge.jar");
                this.label5.Text = path2;
                webClient.DownloadFileAsync(uri, path2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Forgedownload(" https://maven.minecraftforge.net/net/minecraftforge/forge/1.16.5-36.2.34/forge-1.16.5-36.2.34-installer.jar", "forge");
            this.progressBar2.Maximum = 4;
            this.button1.Enabled = false;
            mmap = false;
        }

        private void DownloadProgressCallback4(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            this.label6.Text = string.Concat(Convert.ToString(e.ProgressPercentage), "% / 100%");
        }
        private void DownloadCompletdCallback1(object sender, AsyncCompletedEventArgs e)
        {
            ProgressBar value = this.progressBar2;
            value.Value = value.Value + 1;
            if (this.progressBar2.Value == 1)
            {
                this.label5.Text = "Install Client 버튼을 눌러 포지 설치를 완료해주세요!";
                System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo();
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                processStartInfo.FileName = "java";
                string name2 = WindowsIdentity.GetCurrent().Name;
                if (name2.Contains("\\"))
                {
                    name2.IndexOf("\\");
                    string[] strArrays = name2.Split(new char[] { Convert.ToChar("\\") });
                    string name3 = strArrays[1];
                    string path2 = string.Concat("C:\\Users\\", name3, "\\Downloads\\forge.jar");

                    processStartInfo.CreateNoWindow = true;
                    processStartInfo.Arguments = @"-jar " + path2;
                    process.StartInfo = processStartInfo;
                    process.Start();
                    process.WaitForExit();
                }
                if (opti == true)
                {
                    this.Filedownload(" https://drive.google.com/uc?export=download&id=1_QxrVV4iYJsckW4u1x-hT3tx1hg2TSLl", "Optifine");
                }
                else
                {
                    this.Textdownload(" https://drive.google.com/uc?export=download&id=1EST5NhuKurGkyK6Zvb-iUFWMgp5_WXx8", "null");
                }
            }
            if (this.progressBar2.Value == 2)
            {
                this.Filedownload("https://drive.google.com/uc?export=download&id=1CLCWdwwJTxYWmrxI-E6EPMDtmMpH-FXf&confirm=t&uuid=a3b456bf-f34b-4bde-b8f9-5bcfcd03d0db&at=ALgDtszqSv5Ji_mpIbFDYgpx7nJi:1677318704827", "modzip");
            }
            if (this.progressBar2.Value == 3)
            {
                this.label5.Text = "압축 해제중 입니다.";
                ZipFile.ExtractToDirectory(string.Concat(Form1.path, "\\", "modzip.zip"), string.Concat(Form1.path), true);
                value.Value = value.Value + 1;
                if(MessageBox.Show("확인을 눌러 프로그램을 종료합니다!", "모드 설치가 완료되었습니다!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Process.GetCurrentProcess().Kill();
                }
                
                
            }
        }
    }
}
