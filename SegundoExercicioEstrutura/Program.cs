using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExercicioEstrutura
{
    public class Program
    {
        public int Maior(int num1,int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static void Main(string[] args)
        {
            Program maior = new Program();
            Console.Write("Digite um valor : ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor :");
            int v2 = int.Parse(Console.ReadLine());
            Console.Write("O valor {0} é : ",maior.Maior(v1, v2));
        }
    }
}