namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 204);
            label1.Name = "label1";
            label1.Size = new Size(73, 38);
            label1.TabIndex = 0;
            label1.Text = "현재";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 204);
            label2.Name = "label2";
            label2.Size = new Size(73, 38);
            label2.TabIndex = 0;
            label2.Text = "현재";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 21F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 298);
            label3.Name = "label3";
            label3.Size = new Size(73, 38);
            label3.TabIndex = 0;
            label3.Text = "전체";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 265);
            label4.Name = "label4";
            label4.Size = new Size(425, 15);
            label4.TabIndex = 1;
            label4.Text = "100%로 뜨고 진행되지 않는다해도 기다려주세요! 유효성 검사/설치중 입니다!";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(190, 204);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(443, 38);
            progressBar1.TabIndex = 2;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(190, 298);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(443, 38);
            progressBar2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(633, 397);
            button1.Name = "button1";
            button1.Size = new Size(127, 27);
            button1.TabIndex = 4;
            button1.Text = "다운로드 시작";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(87, 87);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 164);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 435);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 8;
            label7.Text = "Made by 치키이예";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "미누세상 모드 설치기";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
