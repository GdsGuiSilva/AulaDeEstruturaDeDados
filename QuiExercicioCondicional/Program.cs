using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiExercicioCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número entre 1 e 7 :");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.Write("DOMINGO");
                    break;
                case 2:
                    Console.Write("SEGUNDA");
                    break;
                case 3:
                    Console.Write("TERÇA");
                    break;
                case 4:
                    Console.Write("QUARTA");
                    break;
                case 5:
                    Console.Write("QUINTA");
                    break;
                case 6:
                    Console.Write("SEXTA");
                    break;
                case 7:
                    Console.Write("SÁBADO");
                    break;
                default:
                    Console.Write("NÚMERO INVALIDO");
                    break;
            }
        }
    }
}