using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex006
    {
        public void Run() {
            string[] lang = { "kor", "eng", "spa" };
            Console.WriteLine($"{lang[0]},{lang[1]},{lang[2]}");

            //문자열은 메모리할당자 new없이 사용가능
            //why? new 를 쓰는 이유는 내가 데이터값을 얼마나 쓸지 모를때
            //string이 new가 필요가없는이유 저장할때 문자열뒤에있는 \로 알게된다
            //string type new 가 필요한 경우  : ?????????????????????

            string[] str;
            str = new string[3];
            str[0] = "한국";
            str[1] = "미국";
            str[2] = "스페인";
            Console.WriteLine("{0},{1},{2}", str[0], str[1], str[2]);





        }
    }
}
