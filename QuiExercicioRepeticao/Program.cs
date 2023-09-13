using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiExercicioRepeticao
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int a = 0;
            int b = 1;
            int c;
            Console.Write("Os primeiros " + n + " termos da sequência de Fibonacci são: ");
            Console.Write(a + ", " + b);
            int i = 2;
            while (i < n)
            {
                c = a + b;
                Console.Write(", " + c);
                a = b;
                b = c;
                i++;
            }
        }
    }
}
