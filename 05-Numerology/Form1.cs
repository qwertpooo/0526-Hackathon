namespace _05_Numerology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. 取得使用者選擇的日期
            DateTime birthDate = dtpBirthDate.Value;

            // 將日期轉換為純數字字串 (例如：19800816)
            string dateString = birthDate.ToString("yyyyMMdd");

            // 2. 計算生命靈數
            int lifePathNumber = CalculateLifePathNumber(dateString);

            // 3. 判斷星座
            string zodiacSign = GetZodiacSign(birthDate.Month, birthDate.Day);

            // 4. 取得對應評論 (可根據作業提供的網站內容自行擴充)
            string comment = GetComment(lifePathNumber, zodiacSign);

            // 5. 輸出結果
            lblResult.Text = $"你的生日：{birthDate:yyyy年MM月dd日}"+ Environment.NewLine +
                             $"你的星座：{zodiacSign}"+ Environment.NewLine +
                             $"生命靈數：{lifePathNumber}"+ Environment.NewLine +
                             $"【分析評論】\n{comment}";
        }
        private int CalculateLifePathNumber(string numbers)
        {
            int sum = 0;

            // 將字串中的每一個字元轉換成數字並加總
            foreach (char c in numbers)
            {
                // 確保字元是數字
                if (char.IsDigit(c))
                {
                    // 將字元轉為數字 (例如 '9' -> 9)
                    sum += int.Parse(c.ToString());
                }
            }

            // 如果加總結果大於 9，代表還不是個位數，需要再次計算 (遞迴呼叫)
            if (sum > 9)
            {
                return CalculateLifePathNumber(sum.ToString());
            }

            // 如果已經是個位數，直接回傳結果
            return sum;
        }
        private string GetZodiacSign(int month, int day)
        {
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19)) return "牡羊座";
            if ((month == 4 && day >= 20) || (month == 5 && day <= 20)) return "金牛座";
            if ((month == 5 && day >= 21) || (month == 6 && day <= 21)) return "雙子座";
            if ((month == 6 && day >= 22) || (month == 7 && day <= 22)) return "巨蟹座";
            if ((month == 7 && day >= 23) || (month == 8 && day <= 22)) return "獅子座";
            if ((month == 8 && day >= 23) || (month == 9 && day <= 22)) return "處女座";
            if ((month == 9 && day >= 23) || (month == 10 && day <= 23)) return "天秤座";
            if ((month == 10 && day >= 24) || (month == 11 && day <= 21)) return "天蠍座";
            if ((month == 11 && day >= 22) || (month == 12 && day <= 20)) return "射手座";
            if ((month == 12 && day >= 21) || (month == 1 && day <= 20)) return "魔羯座";
            if ((month == 1 && day >= 21) || (month == 2 && day <= 19)) return "水瓶座";
            if ((month == 2 && day >= 20) || (month == 3 && day <= 20)) return "雙魚座";

            return "未知星座";
        }

      
            private string GetComment(int lifeNumber, string zodiac)
        {
            // 將檔案名稱改為你的原始檔名
            string filePath = "生命靈數.txt";

            if (!File.Exists(filePath))
            {
                return "系統提示：找不到檔案 (生命靈數.txt)！請確認檔案已加入專案並設定為「有更新時才複製」。";
            }

            try
            {
                // 讀取所有文字行
                string[] lines = File.ReadAllLines(filePath);

                // 處理「牡羊座」與檔案中「牧羊座」的文字差異
                string searchZodiac = zodiac;
                if (searchZodiac == "牡羊座")
                {
                    searchZodiac = "牧羊座";
                }

                // 設定一個「開關」，用來記錄程式目前是不是讀到了我們要找的星座
                bool isTargetZodiacArea = false;

                // 我們要尋找的目標字串，例如 "生命靈數6："
                string targetPrefix = $"生命靈數{lifeNumber}：";

                foreach (string line in lines)
                {
                    // 忽略空白行
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // 1. 判斷是否為「星座標題行」 (檔案裡的標題都有【 】符號)
                    if (line.Contains("【") && line.Contains("】"))
                    {
                        // 如果這行標題包含要找的星座 (例如包含 "獅子座")
                        if (line.Contains(searchZodiac))
                        {
                            isTargetZodiacArea = true; // 打開開關，表示接下來的內容是我們要找的星座
                        }
                        else
                        {
                            isTargetZodiacArea = false; // 關閉開關，這不是我們要找的星座
                        }
                        continue; // 標題行判斷完畢，直接跳下一行繼續讀
                    }

                    // 2. 如果目前已經進入目標星座的區塊，就開始比對生命靈數
                    if (isTargetZodiacArea)
                    {
                        // 如果這一行包含了我們要找的生命靈數 (例如 "生命靈數6：")
                        if (line.Contains(targetPrefix))
                        {
                            // 找到全形冒號 "：" 的位置
                            int colonIndex = line.IndexOf("：");

                            if (colonIndex != -1)
                            {
                                // 把冒號前面的字切掉，只保留後面的評論內容
                                // colonIndex + 1 代表從冒號的「下一個字」開始取
                                return line.Substring(colonIndex + 1).Trim();
                            }
                            else
                            {
                                // 預防萬一檔案裡用了半形冒號或其他格式
                                return line.Trim();
                            }
                        }
                    }
                }

                return $"目前資料庫中缺少「生命靈數 {lifeNumber}」且為「{zodiac}」的專屬評論。";
            }
            catch (Exception ex)
            {
                return "讀取檔案時發生錯誤：" + ex.Message;
            }
        }
    }
}