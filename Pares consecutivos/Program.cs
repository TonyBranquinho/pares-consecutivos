using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares_consecutivos {
    class Program {
        static void Main(string[] args) {

            int numero, soma;
            
            Console.Write("Digite um numero inteiro: ");
            numero = int.Parse(Console.ReadLine());

            soma = 0;
            while (numero != 0) {
                if (numero % 2 == 0) {
                    soma = (numero) + (numero + 2) + (numero + 4) + (numero + 6) + (numero + 8);
                }
                else if (numero % 2 != 0) {
                    soma = (numero + 1)+(numero+3)+(numero+5)+(numero+7)+(numero+9);
                }
                Console.WriteLine("Soma = " + soma);
                Console.Write("Digite um numero inteiro: ");
                numero = int.Parse(Console.ReadLine());
            }
        }
    }
}
