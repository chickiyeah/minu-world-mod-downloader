using System.Security.Principal;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static string? path;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.path = this.textBox1.Text;
            if (Form1.path == "")
            {
                MessageBox.Show("경로는 공백일수 없습니다!", "경로 오류!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (!new DirectoryInfo(path).Exists)
            {
                MessageBox.Show("경로가 올바르지 않습니다!", "경로 오류!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (MessageBox.Show(string.Concat("이 경로가 맞나요?\n", Form1.path), "경로 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Form2().Show();
                base.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 모든 설치를 취소하고 종료하시겠습니까?", "설치 취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = folderBrowserDialog.SelectedPath;
                Form1.path = this.textBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = WindowsIdentity.GetCurrent().Name;
            if (name.Contains("\\"))
            {
                name.IndexOf("\\");
                string[] strArrays = name.Split(new char[] { Convert.ToChar("\\") });
                this.textBox1.Text = string.Concat("C:\\Users\\", strArrays[1], "\\AppData\\Roaming\\.minecraft\\mods");
                string str = string.Concat("C:\\Users\\", strArrays[1], "\\AppData\\Roaming\\.minecraft\\mods");
                DirectoryInfo directoryInfo = new DirectoryInfo(str);
                if (!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                }
            }
        }
    }
}