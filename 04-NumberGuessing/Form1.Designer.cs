namespace _04_NumberGuessing
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(83, 64);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "開始遊戲";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnStart;
            // 
            // button2
            // 
            button2.Location = new Point(87, 406);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "看答案";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnShowAnswer_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 38);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 160);
            label1.Name = "label1";
            label1.Size = new Size(61, 30);
            label1.TabIndex = 3;
            label1.Text = "輸入";
            // 
            // button3
            // 
            button3.Location = new Point(87, 272);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 4;
            button3.Text = "檢查答案";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnCheck_Click;
            // 
            // button4
            // 
            button4.Location = new Point(261, 272);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 5;
            button4.Text = "放棄重來";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnGiveUp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(563, 62);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 6;
            label2.Text = "遊戲歷程";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(563, 112);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(366, 340);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 544);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
    }
}
