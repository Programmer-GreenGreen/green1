using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex011
    {
        static int FacFor(int n) {
            int result = 1;
            for (int i = 1; i <= n; i++) {
                result *= i;


            }
            return result;


        }

        public void Run() {
            Console.WriteLine(FacFor(4));

        }
       
    }
}
