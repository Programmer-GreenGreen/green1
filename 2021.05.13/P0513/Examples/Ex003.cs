using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex003
    {
        //while break 를 이용해서 1~10 까지 다 더한다 but 23이 넘어가면 break;
        public void Run()
        {
            int num = 0;
            int sum = 0;

            while (true)
            {
                num++;
                sum += num;
                if (sum >= 23) {
                    break;
                }
                Console.WriteLine(sum);



            }
        }
    }
}
