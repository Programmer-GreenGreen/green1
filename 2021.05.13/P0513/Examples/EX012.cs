using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class EX012
    {
        static int Num(int a, int b) {
            int sum = 1;
            for (int i = 1; i <= b; i++) {
                sum = sum * a;
            }
            return sum;
        }
        public void Run()
        {
            Console.WriteLine("첫번 째 값을 입력하세요 :");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("en번 째 값을 입력하세요 :");
            int b = Convert.ToInt32(Console.ReadLine());
          
            int s = Num(a, b);
            Console.WriteLine(s);

        }
    }
}
