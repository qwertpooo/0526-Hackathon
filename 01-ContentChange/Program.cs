namespace _01_ContentChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個大於90的整數:");
            var input = Console.ReadLine();
            //將字串轉換為整數
            int max = int.Parse(input);

            if (max > 90)
            {
                // 使用 for 迴圈從 1 跑到 max
                for (int i = 1; i <= max; i++)
                {
                    if (i % 15 == 0)//最嚴格的先檢查
                    {
                        Console.WriteLine("Dann");
                        
                    }
                    else if(i % 5 == 0)
                    {
                        Console.WriteLine("School");
                    }
                    else if(i % 3 == 0)
                    {
                        Console.WriteLine("Build");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("輸入的數字沒有大於 90。");
            }
        }
    }
}

