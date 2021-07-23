using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0513.Examples
{
    class Ex008
    {
        public void Run()
        {
            int[,] intArr = new int[3, 3];

            for (int i = 0; i <3; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {

                    if (i == j)
                    {

                        intArr[i, j] = 1;

                    }
                    else {

                        intArr[i, j] = 0;
                    }
                    Console.Write(intArr[i, j]);

                }
                Console.WriteLine();
            }
        }




    }




}

