namespace _03_Caculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一句有意義的英文字串:");
            var input = Console.ReadLine();
            // 使用 StringSplitOptions.RemoveEmptyEntries 可以避免多餘的空白被算成單字
            string[] words = input.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // 3. 建立一個字典來儲存單字(Key)與次數(Value)
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // 4. 迴圈檢查每個單字
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    // 如果字典裡已經有這個單字，次數 + 1
                    wordCount[word]++;
                }
                else
                {
                    // 如果字典裡還沒有這個單字，把它加進去，並設定次數為 1
                    wordCount.Add(word, 1);
                }
            }

            foreach (var item in wordCount)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
