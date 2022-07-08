
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolhinhaTicTic
{
    internal class Program
    {


        static void Main(string[] args)
        {
            exercicio8();
        }

        private static void exercicio3()
        {

            string aluno;
            double nota1, nota2, nota3;
            double media;

            Console.WriteLine("digite seu nome");
            aluno = Console.ReadLine();

            Console.WriteLine("digite sua nota");
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());
            nota3 = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3) / 3;


            if (media >= 7)
            {
                Console.WriteLine(aluno + " aprovado! Sua média foi: " + media);
            }
            else
            {
                Console.WriteLine(aluno + "Você não passou.");
            }
            Console.ReadKey();

            /*int Inicial = 1;
            int Final = 100;

            for (int x = Inicial; x <= Final; x++)
            {
               
                if (x % 2 == 0) 
                {
                    Console.WriteLine(x);
                }
                Console.ReadKey();*/



        }

        private static void exercicio6()
        {
            int i;
            i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }
            Console.ReadKey();
        }

        private static void exercicio7()
        {

            int i = 100;

            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.ReadKey();
        }
        private static void exercicio8()
        {

            int i, Numero, Resultado = 1, fatorial;
            Console.WriteLine("Digite um numero:");
            Numero = int.Parse(Console.ReadLine());
            for (i = Numero; i > 0; i--)
            {
                Resultado *= i;
                Console.WriteLine("{0}", Resultado);
                Console.WriteLine("{0}", i);
            }
            fatorial = Resultado;
            Console.WriteLine("O Fatoria do numero {0} é igual a {1};", Numero, fatorial);
            Console.ReadKey();
        }
    }
}