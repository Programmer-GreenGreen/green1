using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex010
    {
        static void Show(int i, int j) {
            Console.WriteLine(i+j);
        }
        public void Run() {
            Show(1,2);
            Show(i: 40, j: 5);
            Show(j: 50, i: 3); //순서를 바꿀수있다


        }
    }
}
//오버로딩의 필요성
//동일한 이름으로 여러작업을 하기 위함
//