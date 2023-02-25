namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 33F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(223, 48);
            label1.Name = "label1";
            label1.Size = new Size(554, 60);
            label1.TabIndex = 0;
            label1.Text = "개척자들 모드 자동 설치기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 179);
            label2.Name = "label2";
            label2.Size = new Size(739, 38);
            label2.TabIndex = 1;
            label2.Text = "미누세상 모드서버 접속에 필요한 모드를 다운로드합니다";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 227);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "설치위치";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 23);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 279);
            label4.Name = "label4";
            label4.Size = new Size(346, 15);
            label4.TabIndex = 4;
            label4.Text = "다음을 눌렀는데 오류가 발생한다면 아래 절차를 진행해주세요.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 307);
            label5.Name = "label5";
            label5.Size = new Size(487, 15);
            label5.TabIndex = 5;
            label5.Text = "위치 확인법 :  윈도우+R 키를 눌러 실행장이 켜지면 %appdata%를 친후 엔터를 누릅니다.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 322);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 337);
            label7.Name = "label7";
            label7.Size = new Size(734, 15);
            label7.TabIndex = 7;
            label7.Text = "그 다음 .minecraft 폴더에 들어가서 mods 폴더가 있으면 거기까지 들어가서 탐색기 상단의 주소를 복사하여 위 입력창에 입력해주세요.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(165, 360);
            label8.Name = "label8";
            label8.Size = new Size(296, 15);
            label8.TabIndex = 8;
            label8.Text = "(폴더가 없는경우 mods 이름으로 직접 생성해주세요!)";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(684, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "다음";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(575, 402);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "취소";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(644, 225);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "찾아보기";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = 미누세상_모드_설치기.Properties.Resources.ab5628ae138bff9f;
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 142);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 432);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 13;
            label9.Text = "Made by 치키이예";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "미누세상 모드 설치기";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label9;
    }
}