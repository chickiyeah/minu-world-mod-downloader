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
                MessageBox.Show("이 경로에 모드를 설치할수 없습니다!", "설치 위치를 선택해주세요!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (!new DirectoryInfo(path).Exists)
            {
                MessageBox.Show("이 경로에 모드를 설치할 수 없습니다!", "이경로는 존재하지 않습니다!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (MessageBox.Show(string.Concat("이 경로가 맞나요?\n", Form1.path), "여기에 설치하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new Form2().Show();
                base.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말 설치를 취소하시겠어요?", "설치를 취소하시겠습니까?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
