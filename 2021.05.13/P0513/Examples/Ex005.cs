using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex005
    {
        public void Run()
        {
            int[] inArr = new int[3] {1,2,3};

            var inArr2 = new int[] { 4, 5, 6 };
            //var 임의변수 우항의 타입에따라 변수의 타입이 정해진다
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i}번째 인덱스 : {inArr[i]}");
                Console.WriteLine($"{i}번째 인덱스 : {inArr2[i]}");
            }
            foreach (int inVal in inArr)
            {
                Console.WriteLine("{0}", inVal);
            }
            foreach (int inVal2 in inArr2)
            {
                Console.WriteLine("{0}", inVal2);
            }
        }
    }
}
