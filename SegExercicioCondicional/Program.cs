using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace SegExercicioCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do aluno :");
            float nota = float.Parse(Console.ReadLine());
            if (nota >= 7)
            {
                Console.Write("APROVADO!!");
            }
            else
            {
                Console.Write("REPROVADO!!");
            }
        }
    }
}