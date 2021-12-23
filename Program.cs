using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstname = "João";
            string lastname = "Santos";
            //imprimindo nosso output
            Console.WriteLine("\n\nQual é o seu nome? " + "\n");
            Console.WriteLine("Meu nome é {0} {1}", firstname, lastname + "\n\n");

            int idade;
            idade = 19;
            Console.WriteLine("\n\nQual é sua idade? " + "\n");
            Console.WriteLine("\n\nQual é sua idade? " + "\n");
            Console.WriteLine(
                "Minha idade é {0} ", idade + "\n\n" 
                );
            Console.ReadLine();
        }
    }
}
