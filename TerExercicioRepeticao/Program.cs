using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerExercicioRepeticao
{
    public class Program
    {
        static void Main(string[] args)
        {
            float media = 0;
            int cont = 0;
            float aux = 0;
            Console.Write("Digite um número :");
            float num = float.Parse(Console.ReadLine());
            while (num >= 0)
            {
                aux = aux + num;
                cont++;
                num = float.Parse(Console.ReadLine());
            }
            if (cont == 0)
            {
                Console.Write("Não foram digitados números validos");
            }
            else
            {
                media = aux / cont;
                Console.Write("Números digitados : {0}. A média é : {1}", cont, media);
                Console.ReadKey();
            }
        }
    }
}