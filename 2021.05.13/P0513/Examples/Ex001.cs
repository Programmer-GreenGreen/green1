using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex001
    {
        //cotinue 1~10까지 3의 배수를 뺀 합을 구해라


        public void Run() {
           
            int sum = 0;

            for (int i = 0; i <= 10; i++)
            {
                if (i % 3 == 0) {
                    continue;
                }
                sum += i;

            }
            Console.WriteLine(sum);

        }
    }
}
