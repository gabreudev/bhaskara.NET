using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

          Console.Write("digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            int delta = ((b * b) - 4 * a * c);
            if (delta >= 0)
            {
                double raizdelta = Math.Sqrt(delta);
                double x1 = ((-b + raizdelta) / 2 * a);
                double x2 = ((-b + raizdelta) / 2 * a);
                Console.WriteLine($"x1 é igual {x1}");
                Console.WriteLine($"x2 é igual {x2}");

            }
            else
            {
                Console.WriteLine($"O valor de delta é {delta}");
            }

        