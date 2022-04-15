using Microsoft.AspNetCore.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            this.label5.Text = string.Concat(Form1.path, "\\", name, ".jar");
            webClient.DownloadFileAsync(uri, string.Concat(Form1.path, "\\", name, ".jar"));
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
            this.progressBar2.Maximum = 21;        
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
                    this.Filedownload(" https://drive.google.com/uc?export=download&id=1_QxrVV4iYJsckW4u1x-hT3tx1hg2TSLl", "Optifine");
                }
                else
                {
                    this.Textdownload(" https://drive.google.com/uc?export=download&id=1EST5NhuKurGkyK6Zvb-iUFWMgp5_WXx8", "옵티파인미설치");
                }
            }
            if (this.progressBar2.Value == 2)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1fhfDDfmx3CSw9ZultynRH9X5SaT2FOVb", "AI");
            }
            if (this.progressBar2.Value == 3)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1qDQw1Z32z_E2UiEq_3-v5Sww_S7W2RsX", "freeitecore");
            }
            if (this.progressBar2.Value == 4)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1VAeQQrcwAkogv6huwwI2KyxerO5excD8", "DataFixerslayer");
            }
            if (this.progressBar2.Value == 5)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1wCnAwlbSrnIPEuqFT50ycI2B-k-05Vpr", "foodextend");
            }
            if (this.progressBar2.Value == 6)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1wRDZTWYH4RQRai2zMtg-pXdHl_Jbo6ig", "trees");
            }
            if (this.progressBar2.Value == 7)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=11T8vq8b7RasldA-BXhW6UwOcbEX75K9G", "crops");
            }
            if (this.progressBar2.Value == 8)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1wMe4vSZwcO9ocJ9IV_iZKwcdZYdZPhi9", "foodcore");
            }
            if (this.progressBar2.Value == 9)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=14zj61hbBdP9QmQ5YBKNxRn7howLzNqzC", "Furniture");
            }
            if (this.progressBar2.Value == 10)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1dpxBDLvTv4LMxjrShhnDdVl90koXKYBP", "placebo");
            }
            if (this.progressBar2.Value == 11)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1EZJWe25GDxj5ejfvapy2TxBSIL9vHx0X", "FastFurnace");
            }
            if (this.progressBar2.Value == 12)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1bgfNA1bn3xtKe1FwHpSihVYLR6J5GzEn", "Architectury");
            }
            if (this.progressBar2.Value == 13)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1w23wBsesxW7_e3bhA-_ZvPxhnaTSdpjN", "FTB-GUI-LIBRARY");
            }
            if (this.progressBar2.Value == 14)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1Ugt4NZgpE_HsewkBBjEykkLBJNKvM2Zt", "JEI");
            }
            if (this.progressBar2.Value == 15)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1xzvTMa0tQOqtEgqfIQRiISpkbEz4wPR5", "Marketbasket");
            }
            if (this.progressBar2.Value == 16)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1WwWDKWCT4fo6tz9vwSAGMUiWBSOHxcnb", "MCW-Bridges");
            }
            if (this.progressBar2.Value == 17)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1XDuDZbE16HiK5ISVi4SchA3HNSGI9zNE", "Buildersedtions");
            }
            if (this.progressBar2.Value == 18)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=166oWi7xHQCQJYgI7f_smrrpi5c1pjNbK", "Carry-On");
            }
            if (this.progressBar2.Value == 19)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1oBM-Gq5gAZUUUQdJBBLo0Zu2qYd88ro0", "shetiphiancore");
            }
            if (this.progressBar2.Value == 20)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1OJO6TLT57DdncupG50OO-8GFutxbCL_F", "Multi-Beds");
            }
            if (this.progressBar2.Value == 21)
            {
                this.Filedownload(" https://drive.google.com/uc?export=download&id=1G7ZyDbNu9PTWtqz0wUhumPKzveDZdm6C", "Cooking");
            }
            if (this.progressBar2.Value == 22)
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
