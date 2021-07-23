using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex009
    {
        static int sum(int a, int b) {
           
            return (a + b);

        }

        

        //함수이름, 함수의 결과값, 함수변수의 타입
        //
        public void Run() {
            Console.WriteLine("첫번째 값");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두번째 값");
            int b = Convert.ToInt32(Console.ReadLine());

            int s = sum(a,b);
            Console.WriteLine("합계 : {0}",s);



        }
    }
}
