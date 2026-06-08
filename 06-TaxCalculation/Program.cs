namespace _06_TaxCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 提示使用者輸入年收入
            Console.WriteLine("請輸入您的年收入：");
            string input = Console.ReadLine();

            // 2. 將字串轉換為 Decimal 型別
            // 從 Console 讀取的是 string，必須轉換才能運算
            if (decimal.TryParse(input, out decimal income))
            {
                decimal tax = 0;

                // 3. 使用 if - else if 判斷稅率級距
                // 依照中華民國累進稅率公式計算
                if (income <= 540000m)
                {
                    tax = income * 0.05m;
                }
                else if (income <= 1210000m)
                {
                    tax = (540000m * 0.05m) + (income - 540000m) * 0.12m;
                }
                else if (income <= 2420000m)
                {
                    tax = (540000m * 0.05m) + (1210000m - 540000m) * 0.12m + (income - 1210000m) * 0.20m;
                }
                else if (income <= 4530000m)
                {
                    tax = (540000m * 0.05m) + (1210000m - 540000m) * 0.12m + (2420000m - 1210000m) * 0.20m + (income - 2420000m) * 0.30m;
                }
                else if (income <= 10310000m)
                {
                    tax = (540000m * 0.05m) + (1210000m - 540000m) * 0.12m + (2420000m - 1210000m) * 0.20m + (4530000m - 2420000m) * 0.30m + (income - 4530000m) * 0.40m;
                }
                else
                {
                    tax = (540000m * 0.05m) + (1210000m - 540000m) * 0.12m + (2420000m - 1210000m) * 0.20m + (4530000m - 2420000m) * 0.30m + (10310000m - 4530000m) * 0.40m + (income - 10310000m) * 0.50m;
                }

                // 4. 顯示計算結果，使用字串插補 ($) 方式
                Console.WriteLine($"您的年收入為：{income:N0} 元");//N千分位符號0保留零位小數(只保留整數)
                Console.WriteLine($"應繳納稅額為：{tax:N0} 元");
            }
            else//輸入非數字等等讓轉換失敗
            {
                Console.WriteLine("輸入格式錯誤，請輸入數字。");
            }

            Console.ReadLine(); // 防止視窗直接關閉
        }
    }
}
