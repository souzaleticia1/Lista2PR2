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

            //int n;

            //Console.WriteLine("Digite um número: ");
            //n = int.Parse(Console.ReadLine());

            //if (n % 3 == 0 && n % 5 == 0)
            //{
            //    Console.WriteLine("O número " + n + " é divisível por 3 e por 5");
            //}
            //else
            //{
            //    if (n % 3 == 0)
            //    {
            //        Console.WriteLine("O número " + n + " é divisível por 3");
            //    }
            //    else
            //    {
            //        if (n % 5 == 0)
            //        {
            //            Console.WriteLine("O número " + n + " é divisível por 5");
            //        }
            //        else
            //        {
            //            Console.WriteLine("O número " + n + " não é divisível por 3 e por 5");
            //        }
            //    }
            //}
            //Console.ReadKey();


            //Exercício 6.

            //int ang1, ang2, ang3, t;

            //Console.WriteLine("Digite o primeiro ângulo: ");
            //ang1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo ângulo: ");
            //ang2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro ângulo: ");
            //ang3 = int.Parse(Console.ReadLine());

            //t = ang1 + ang2 + ang3;

            //if(t != 180)
            //{
            //    Console.WriteLine("Não é um triângulo!");
            //}
            //else
            //{
            //    if(ang1 == 90 || ang2 == 90 || ang3 == 90)
            //    {
            //        Console.WriteLine("É um triângulo retângulo");
            //    }
            //    else
            //    {
            //        if(ang1 > 90 || ang2 > 90 || ang3 > 90)
            //        {
            //            Console.WriteLine("É um triângulo obtusângulo");
            //        }
            //        else
            //        {
            //            if(ang1 < 90 && ang2 < 90 && ang3 < 90)
            //            {
            //                Console.WriteLine("É um triângulo acutângulo");
            //            }
            //        }
            //    }
            //}
            //Console.ReadKey();


            //Exercício 7.

            //int num1, num2, num3;

            //Console.WriteLine("Digite o primeiro número: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número: ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro número: ");
            //num3 = int.Parse(Console.ReadLine());

            //if(num1 == num2 || num1 == num3 || num2 == num3)
            //{
            //    Console.WriteLine("Números iguais não são válidos");
            //}
            //else
            //{
            //    if(num1 < num2 && num2 < num3)
            //    {
            //        Console.WriteLine(num1 + " " + num2 + " " + num3);
            //    }
            //    else
            //    {
            //        if(num1 < num3 && num3 < num2)
            //        {
            //            Console.WriteLine(num1 + " " + num3 + " " + num2);
            //        }
            //        else
            //        {
            //            if (num2 < num1 && num1 < num3)
            //            {
            //                Console.WriteLine(num2 + " " + num1 + " " + num3);
            //            }
            //            else
            //            {
            //                if (num2 < num3 && num3 < num1)
            //                {
            //                    Console.WriteLine(num2 + " " + num3 + " " + num1);
            //                }
            //                else
            //                {
            //                    if (num3 < num1 && num1 < num2)
            //                    {
            //                        Console.WriteLine(num3 + " " + num1 + " " + num2);
            //                    }
            //                    else
            //                    {
            //                        if (num3 < num1 && num2 < num1)
            //                        {
            //                            Console.WriteLine(num3 + " " + num2 + " " + num1);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.ReadKey();


            //Exercício 8.

            //int ano;

            //Console.WriteLine("Digite uym ano: ");
            //ano = int.Parse(Console.ReadLine());

            //if(ano %4 == 0)
            //{
            //    Console.WriteLine("O ano " + ano + " é um ano bissexto");
            //}
            //else
            //{
            //    Console.WriteLine("O ano " + ano + " não é um ano bissexto");
            //}
            //Console.ReadKey();


            //Exercício 9.

            int num1, num2, so, su, mu, di;
            char op;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador a ser utilizado: ");
            op = char.Parse(Console.ReadLine());

            so = num1 + num2;
            su = num1 - num2;
            mu = num1 * num2;
            di = num1 / num2;

            if(op == '+')
            {
                Console.WriteLine("Resultado: " + so);
            }
            else
            {
                if(op == '-')
                {
                    Console.WriteLine("Resultado: " + su);
                }
                else
                {
                    if(op == '*')
                    {
                        Console.WriteLine("Resultado: " + mu);
                    }
                    else
                    {
                        if(op == '/')
                        {
                            Console.WriteLine("Resultado: " + di);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
