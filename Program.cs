using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerccicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempture=0;
            string unidade;
            double conversor;
            
            Console.WriteLine("Digite a temperatura: ");
            tempture = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite para qual unidade quer cnverter");
            unidade = Console.ReadLine();
            if (unidade== "Fariet" || unidade == "fariet" || unidade == "Celsius" || unidade == "celsius")
            {
                if (unidade == "Fariet" || unidade == "fariet")
                {
                    conversor = (tempture - 32) * (double)5 / 9;
                    Console.WriteLine("Temos " + conversor);
                }

                else if (unidade == "celsius" || unidade == "celsius")
                {
                    conversor = (tempture - 9 / 5) + 32;
                    Console.WriteLine("Temos " + conversor);
                }
            }
            else {
                while (true)
                {
                    Console.WriteLine("Digite apenas o Fariet ou o Celsius unidade quer cnverter");
                    unidade = Console.ReadLine();
                    if (unidade == "Fariet" || unidade == "fariet")
                    {
                        conversor = (tempture - 32) * (double)5 / 9;
                        Console.WriteLine("Temos " + conversor);
                        break;
                    }
                    else if (unidade == "Celsius" || unidade == "celsius")
                    {
                        conversor = (tempture - 9 / 5) + 32;
                        Console.WriteLine("Temos " + conversor);
                        break;

                    }

                }
            }
            Console.ReadKey();
        }
    }
}
