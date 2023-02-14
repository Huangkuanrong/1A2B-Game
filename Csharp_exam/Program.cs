using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exam
{
    internal class Program
    {
        private static List<int> randNumber()
        {
            List<int> list = new List<int>();
            while (list.Count < 4)
            {
                Random random = new Random();
                int number = random.Next(1, 10);
                if (list.Contains(number) == false || list.Count == 0)
                {
                    list.Add(number);
                }
            }
            return(list);
        }

        private static string checkSame(string num1, string num2)
        {
            int A = 0;
            int B = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    if (num1[i] == num2[j] && i == j)
                    {
                        A++;
                    }
                    else if (num1[i] == num2[j])
                    {
                        B++;
                    }
                }
            }
            return($"{A.ToString()}A{B.ToString()}B");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string num = string.Join("", randNumber());
                Console.WriteLine(num);
                Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～\n------\n");
                string output = "";
                while (output != "4A0B")
                {
                    Console.Write("請輸入 4 個數字：");
                    string input = Console.ReadLine();
                    output = checkSame(num, input);
                    Console.WriteLine(output);
                }
                Console.Write("恭喜你！猜對了！！\r\n------\r\n你要繼續玩嗎？(y/n): ");
                if (Console.ReadLine() == "n")
                {
                    Console.WriteLine("遊戲結束，下次再來玩喔～");
                    break;
                }
            }
            
        }
    }
}
