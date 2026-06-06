using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace _04_NumberGuessing
{
    public partial class Form1 : Form
    {
        private string answer = "";
        public Form1()
        {
            InitializeComponent();
            // 初始狀態設定：還沒按開始前，不能輸入、檢查、放棄或偷看答案
            textBox1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false; 
        }

        private void btnStart(object sender, EventArgs e)
        {
            GenerateAnswer();
            textBox2.Clear();
            textBox2.AppendText("遊戲開始！請輸入4個不重複的數字。\r\n");

            // 啟用遊戲進行中的控制項
            textBox1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = true; 

            textBox1.Clear();
            textBox1.Focus();//將系統的「焦點」強制設定在這個輸入框上（讓輸入框出現閃爍的游標）
        }
        // 產生 0~9 隨機不重複的 4 個數字
        private void GenerateAnswer()
        {
            Random rnd = new Random();
            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            answer = "";

            for (int i = 0; i < 4; i++)
            {
                int index = rnd.Next(numbers.Count);//決定這次要從箱子裡抽出「第幾個」位置的球。(抽位置不是數字)
                answer += numbers[index].ToString();//轉成字串後加到answer中
                numbers.RemoveAt(index);//拿掉剛抽到的數字以避免重複
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text.Trim();

            // 輸入驗證：必須是4個字元、必須是數字、必須不重複
            if (guess.Length != 4 || !guess.All(char.IsDigit) || guess.Distinct().Count() != 4)//char.IsDigit 是一個專門檢查字元「是不是數字 0~9」的功能
            {
                MessageBox.Show("請輸入『4個不重複』的數字！", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }

            int aCount = 0;
            int bCount = 0;

            // 判斷 A 和 B 的數量
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                {
                    aCount++; 
                }
                else if (answer.Contains(guess[i]))
                {
                    bCount++; 
                }
            }
            // 將結果寫入遊戲歷程
            string resultText = $"{guess} ➔ {aCount}A{bCount}B";
            textBox2.AppendText(resultText + Environment.NewLine);//換行

            // 判斷是否獲勝
            if (aCount == 4)
            {
                MessageBox.Show("恭喜你！猜對了！"+ Environment.NewLine+"答案就是：" + answer, "遊戲勝利", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 遊戲結束，鎖定控制項
                textBox1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
          
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("真可惜！正確答案是：" + answer, "放棄遊戲", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 將狀態重置回尚未開始
            textBox1.Enabled = false;
            textBox1.Clear();
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false; 

            textBox2.AppendText("遊戲結束。請點擊「開始遊戲」重新挑戰。" + Environment.NewLine);
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            // 彈出視窗顯示答案，但不結束遊戲
            MessageBox.Show($"目前的正確答案是：{answer}", "偷看答案", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Focus(); // 讓游標回到輸入框繼續猜
        }

     

    }

}
