using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1.

            //float l, rMenos = 0.35f, rMais = 0.28f, p;

            //Console.WriteLine("Quantas laranjas você comprou? ");
            //l = float.Parse(Console.ReadLine());

            //if (l < 12)
            //{
            //    p = l * rMenos;
            //}
            //else
            //{
            //    p = l * rMais;
            //}
            //Console.WriteLine("O total a pagar é de: R$" + p);
            //Console.ReadKey();


            //Exercício 2.

            //int ano = 2023, anoP, idade;

            //Console.WriteLine("Digite o ano em que você nasceu: ");
            //anoP = int.Parse(Console.ReadLine());

            //idade = ano - anoP;

            //if(idade < 16)
            //{
            //    Console.WriteLine("Você não poderá votar esse ano");
            //}
            //else
            //{
            //    Console.WriteLine("Você poderá votar esse ano");
            //}
            //    Console.ReadKey();


            //Exercício 3.

            //int ladoA, ladoB, ladoC;

            //Console.WriteLine("Digite a medida do ladoA: ");
            //ladoA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a medida do ladoB: ");
            //ladoB = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a medida do ladoC: ");
            //ladoC = int.Parse(Console.ReadLine());

            //if (ladoA == ladoB && ladoA == ladoC)
            //{
            //    Console.WriteLine("É um triângulo equilátero");
            //}
            //else
            //{
            //    if(ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            //    {
            //        Console.Write("É um triângulo isósceles");
            //    }
            //    else
            //    {
            //        Console.WriteLine("É um triângulo escaleno");
            //    }
            //}
            //    Console.ReadKey();


            //Exercício 4.

            //double a, b, c, d, x1, x2;

            //Console.WriteLine("Digite o valor de A: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de B: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de C: ");
            //c = double.Parse(Console.ReadLine());

            //d = ((b * b) - (4 * a * c));
            //x1 = ((-b + Math.Sqrt(d)) / (2 * a));
            //x2 = ((-b - Math.Sqrt(d)) / (2 * a));

            //if(b == 0 || c == 0)
            //{
            //    Console.WriteLine("Equação incompleta!");
            //}
            //else
            //{
            //    if(d < 0)
            //    {
            //        Console.WriteLine("Esta equação não possui raízes reais!");
            //    }
            //    else
            //    {
            //        if(d == 0)
            //        {
            //            Console.WriteLine("Esta equação possui duas raízes reais iguais!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Esta equação possui duas raízes reais diferentes!");

            //            Console.WriteLine("x1 = " + x1);
            //            Console.WriteLine("x2 = " + x2);
            //        }
            //    }
            //}
            //Console.ReadKey();


            //Exercício 5.

            int n;

            Console.WriteLine("Digite um número: ");
            n = int.Parse(Console.ReadLine());

            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("O número " + n + " é divisível por 3 e por 5");
            }
            else
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine("O número " + n + " é divisível por 3");
                }
                else
                {
                    if (n % 5 == 0)
                    {
                        Console.WriteLine("O número " + n + " é divisível por 5");
                    }
                    else
                    {
                        Console.WriteLine("O número " + n + " não é divisível por 3 e por 5");
                    }
                }
            }
            Console.ReadKey();


            //Exercício 6.


        }
    }
}
