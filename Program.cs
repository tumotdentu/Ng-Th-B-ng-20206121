using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20206121_bai2_2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("So nguyen: ");
                int n; bool flag = true; string s;
                s = Console.ReadLine();
                if (s == "\\s") goto BREAK;
                while (!Int32.TryParse(s, out n))
                {
                    Console.WriteLine("Nhap lai: ");
                };
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (n == 0 || n == 1)
                {
                    flag = false;
                }
                string output = flag ? "{0} la mot so nguyen to." : "{0} khong phai la mot so nguyen to.";
                Console.WriteLine(output, n);
                Console.ReadLine();
            }
        BREAK: return;
        }
    }
}
