using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegExercicioSequencial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome :");
            String nome = Console.ReadLine();
            Console.Write("Digite sua idade :");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Seu nome é {0} com {1} anos de idade",nome,idade);
        }
    }
}
