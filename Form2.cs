using Microsoft.AspNetCore.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.label5.Text = string.Concat(Form1.path, "\\", name);
            webClient.DownloadFileAsync(uri, string.Concat(Form1.path, "\\", name));
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
            this.Forgedownload(" https://maven.minecraftforge.net/net/minecraftforge/forge/1.16.4-35.1.36/forge-1.16.4-35.1.36-installer.jar", "forge");
            this.progressBar2.Maximum = 4;        
            this.button1.Enabled = false;
            this.checkBox1.Enabled = false;
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
                    this.Filedownload(" https://drive.google.com/uc?export=download&id=1_QxrVV4iYJsckW4u1x-hT3tx1hg2TSLl", "Optifine.jar");
                }
                else
                {
                    this.Textdownload(" https://drive.google.com/uc?export=download&id=1EST5NhuKurGkyK6Zvb-iUFWMgp5_WXx8", "옵티파인미설치");
                }
            }
            if (this.progressBar2.Value == 2)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1ZkmlDKetpXsel5m3dZeThtnL7kyU4zq0", "mods.zip");
            }
            if (this.progressBar2.Value == 3)
            {
                try
                {
                    ZipFile.ExtractToDirectory(Form1.path+"\\mods.zip", Form1.path);
                    File.Delete(Form1.path + "\\mods.zip");
                    MessageBox.Show("모든 다운로드를 완료했습니다!\n본 프로그램을 종료해도 좋습니다!", "다운로드 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    File.Delete(Form1.path + "\\mods.zip");
                    MessageBox.Show("아름다운 오류입니다. 압축 헤제에 실패했습니다.\n기존 모드를 모드 제거 했는지 확인해주세요.\n "+ex);
                }
            }
        
            if (this.progressBar2.Value == 4)
            {
                MessageBox.Show("모든 다운로드를 완료했습니다!\n본 프로그램을 종료해도 좋습니다!", "다운로드 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                opti = true;
            }
            else
            {
                opti = false;
            }
            
        }
    }
}
