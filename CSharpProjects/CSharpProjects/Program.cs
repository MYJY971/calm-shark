using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            String myString, string2;
            float[,] tab = new float[2, 3] { { 1, 2, 3}, { 4, 5, 6 } };
            Console.WriteLine("Hello World");
            string2 = "caca";
            myString = " "+tab[0,0]+" "+tab[0,1]+" "+tab[0,2]+"\n"+
                       " " + tab[1, 0] + " " + tab[1, 1] + " " + tab[1, 2] + "\n";
           // Console.WriteLine(myString);
            int row = tab.GetLength(0);
            int col = tab.GetLength(1);
            int size = row * col;

            String stringValue = "\n";
            String string3="2";
            for(int r=0; r<row; ++r)
            {
                for (int c=0; c<col; ++c)
                {
                    if (c != col - 1)
                        stringValue =stringValue+ " " + tab[r, c];
                    else
                        stringValue =stringValue+ " " + tab[r, c] + "\n";
                }
            }

            string3 = string3 + "\n "+7;
            

            Console.WriteLine(stringValue);

            Console.WriteLine("--------------------");

            Matrix M = new Matrix(3);

            Console.WriteLine(M.ToString());





        }
    }
}
