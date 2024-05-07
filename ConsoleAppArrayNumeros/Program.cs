using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont_ma = int.MinValue;
            int cont_mn = int.MaxValue;

            Console.WriteLine("Insira a quantidade de números: ");
            int quant = int.Parse(Console.ReadLine());

            int[] num = new int[quant];

            for (int i = 0; i < quant ; i++)
            {
                Console.WriteLine("Insira o número: ");
                num[i] = int.Parse(Console.ReadLine());

                if (cont_mn > num[i])
                {
                    cont_mn = num[i];
                }
                if (cont_ma < num[i])
                {
                    cont_ma = num[i];
                }
            }
            Console.WriteLine("Os números digitados foram: ");
            for (int j = 0; j < quant ; j++)
            {
                Console.Write(" " +num[j]);
            }

            Console.WriteLine("\n O menor número digitado foi:  " + cont_mn);
            Console.WriteLine("O maior número digitado foi: " + cont_ma);
            Console.ReadKey();  
        }
    }
}
