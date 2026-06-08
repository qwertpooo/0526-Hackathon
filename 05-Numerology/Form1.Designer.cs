namespace _05_Numerology
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
            label1 = new Label();
            label2 = new Label();
            dtpBirthDate = new DateTimePicker();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 58);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 0;
            label1.Text = "請輸入生日";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(453, 58);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 1;
            label2.Text = "關於你";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(57, 116);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(288, 38);
            dtpBirthDate.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(119, 234);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 86);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "分析結果";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(457, 116);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 30);
            lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(dtpBirthDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpBirthDate;
        private Button btnCalculate;
        private Label lblResult;
    }
}
