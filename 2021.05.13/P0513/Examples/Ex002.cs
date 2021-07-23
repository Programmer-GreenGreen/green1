using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex002
    {
        public void Run()
        {
            string str = "ABC123";

            foreach (char c in str)
            {

                Console.Write($"{c}\t"); //char type 의 c에 str의 값을 저장  char => var로 사용해도된다
                                         //$ => 문자열로 표현
                                         //var , dynamic, object 변수를 선언하는 변수

            }
            Console.WriteLine(); //계속하려면 아무키나 누르시오 를 다음줄에 출력
        }
    }
}
