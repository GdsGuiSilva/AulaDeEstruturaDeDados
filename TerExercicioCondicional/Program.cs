﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerExercicioCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor :");
            float valor = float.Parse(Console.ReadLine());
            if(valor % 2 == 0)
            {
                Console.Write("Valor é par");
            }
            else
            {
                Console.Write("Valor é ímpar");
            }
        }
    }
}
