using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex004
    {
        public void Run()
        {
            Console.WriteLine("시작");

        Start:
            Console.WriteLine("0,1,2 중 하나 입력 : _\b");
            int c = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine() => 사용자가 입력한 값을 Int타입으로 변환

            if (c == 1)
            {
                goto c1; // 라벨 
                //goto문을 사용하면 바로 라벨로 간다.

            }
            else if (c == 2)
            {
                goto c2;

            }
            else
            {
                goto End;
            }
        c1: Console.WriteLine("1입니다");
            goto Start;
        c2: Console.WriteLine("2입니다");
            goto Start; //Start로 가라

        End: Console.WriteLine("종료");

        }
    }
}
