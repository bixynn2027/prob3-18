using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(‐10～35)：");
            int a = int.Parse(Console.ReadLine());
            if (a > -10 && a < 35)
            {
                Console.WriteLine("摂氏{0}度", a);
                if (a >= 30)
                {
                    Console.WriteLine("真夏日です");
                }
                else if (a <= 0)
                {
                    Console.WriteLine("真冬日です");
                }
                else if (a >= 25 && a <= 30)
                {
                    Console.WriteLine("夏日です");
                }
            }
            else
            {
                Console.WriteLine("適切な値を入力してください");
            }
        }
    }
}
