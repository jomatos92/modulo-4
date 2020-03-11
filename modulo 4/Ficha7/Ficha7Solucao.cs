using System;

namespace Ficha7
{
    public class Ficha7Solucao
    {
        #region Exerciocio1
        public static void exercicio1()
        {
            double nota;

            Console.Write("introduza a nota");
            nota = double.Parse(Console.ReadLine());

            if (nota <= 9.44)
            {
                Console.WriteLine("chumbou");

            }
            else
            {
                Console.WriteLine("passou");
            }




        }
        #endregion

        #region Exercicio2
        public static void exercicio2()
        {
            double altura, peso, bmi;

            Console.WriteLine("solicitar peso ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("solicitar altura ");
            altura = double.Parse(Console.ReadLine());

            bmi = peso / (altura * altura);

            if (bmi < 18.5)
            {
                Console.WriteLine("abaixo peso");

            }
            else if ((bmi >= 18.5) && (bmi <= 24.9))
            {
                Console.WriteLine("acima do peso");


            }
            else if ((bmi >= 25) && (bmi <= 29.9))
            {
                Console.WriteLine("obeso");


            }

            Console.WriteLine(bmi);
            Console.ReadKey();


        }
        #endregion

        #region Exercicio3
        public static void Exercicio3()
        {
            int num;

            Console.WriteLine("solicitar numero");
            num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine("é multiplo dos dois numeros ");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("multiplo de 3");

            }

            else if (num % 7 == 0)
            {
                Console.WriteLine("multiplo de 7");
            }
            else
            {
                Console.WriteLine("não é multiplo nem de 3 nem de 7");
                Console.ReadKey();
            }

        }
        #endregion

        #region Exercicio4
        public static void Exercicio4()
        {
            int num;

            Console.WriteLine("intruduzir numero ");
            num = int.Parse(Console.ReadLine());

            if (num >= 30 && num <= 50)
            {
                Console.WriteLine("o numero encontra entre 30 e 50");

            }
            else
            {
                Console.WriteLine("não se encontra");
            }
        }
        #endregion

        #region Exercicio5
        static public void Exercicio5()
        {
                int num;

                Console.WriteLine("intruduzir numero ");
                num = int.Parse(Console.ReadLine());

                if (num > 10 && num < 20) 
                {
                Console.WriteLine("o numero encontra entre 10 e 20");

                }
                else
                {
                    Console.WriteLine("não se encontra");
                }
        }

        #endregion

        #region Exerciocio6

        public static void Exerciocio6()
        {

        }


        #endregion

    }


}
