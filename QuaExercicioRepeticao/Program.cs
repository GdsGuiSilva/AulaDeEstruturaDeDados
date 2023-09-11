using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuaExercicioRepeticao
{
    public class Program
    {
        static void Main(string[] args)
        {
            int verifica = 0;
            int senha = 150115;
            do
            {
                Console.Write("Digite sua senha :");
                verifica = int.Parse(Console.ReadLine());
                if (verifica != senha)
                {
                    Console.Write("SENHA INCORRETA!!");
                }
            } while (verifica != senha);
            Console.Write("LOGIN EFETUADO COM SUCESSO");
        }
    }
}
