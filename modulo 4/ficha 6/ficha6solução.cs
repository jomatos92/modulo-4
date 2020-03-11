using System;

namespace ficha_6
{
    public class ficha6solução
    {
        //    #region 
        //    public static void Exercicio1()
        //    {
        //        Console.WriteLine("qualé o nome?");
        //        var nome = Console.ReadLine();
        //        OlaNome(nome);
        //    }
        //    public static void OlaNome(string nome)
        //    {
        //        Console.WriteLine("olá " + nome);
        //    }

        //}
        //#endregion
        #region exercico 2


        public static void Exercicio2()
        {
            Console.WriteLine("num 1?");
            var num1 = Console.ReadLine();
            Console.WriteLine("num 2");
            var num2 = Console.ReadLine();
            var num1Conv = ConverterStringParaNumero(num1);
            var num2Conv = ConverterStringParaNumero(num2);
            ApresentarSoma(num1Conv, num2Conv);


        }
        public static int ConverterStringParaNumero(string num)
        {
            var parceOK = int.TryParse(num, out int parsedNum);
            return parsedNum;



        }

        public static void ApresentarSoma(int numA, int numB)
        {
            Console.WriteLine(numA + "+" + numB + "=" + (numA + numB));





            #endregion
        }
        public static int LerNumConvert()
        {
            Console.WriteLine("Numero?");
            var num = Console.ReadLine();
            return ConverterStringParaNumero(num);
        }


        public static void Exercicio3()
        {
            var num1 = LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            num1 += LerNumConvert();
            Console.WriteLine(num1);

            #region Ex
            {
                Console.WriteLine("Primeiro número");
                int.TryParse(Console.ReadLine(), out int numero1);
                Console.WriteLine("segundo número?");
                //string b= Console.WriteLine

                   
                //{
                //    Console.WriteLine("Primeiro número?");
                //    var num1 =(Console.ReadLine());
                //    Console.WriteLine("Segundo número");
                //    var num2 = int.Parse(Console.ReadLine());

                //    #endregion

                //}
                

                //public static void Exercicio5b()
                //    {
                //        Console.WriteLine("Numero");
                //        var num1 = ConverterStringParaNumero(Console.ReadLine());
                //        Console.WriteLine("Segundo número");
                //        var num2 = int.Parse(Console.ReadLine());
                //        Console.WriteLine("Terceiro número");
                #endregion

            }
           
        }
        public static void Exercicio5c()
        {
            Console.WriteLine("qual o primeiro número?");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o segundo número?");
            var numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o terceiro número?");
            var numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o quarto número ?");
            var numero4 = int.Parse(Console.ReadLine());
            var calcular = numero1 + numero2 + numero3 + numero4;
            Console.WriteLine(numero1 + "+" + numero2 + "*" + numero3 + "/ " + numero4);
        }

        public static void Exercicio7()
        {
            Console.WriteLine("qual é o numero: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual é o numero: ");
            var numero2 = int.Parse(Console.ReadLine());
            ApresentarMedia(numero1, numero2);

        }
        public static void ApresentarMedia(int numero1, int numero2)
        {
            Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));

        }

        public static void Exercicio8()
        {
            Console.WriteLine("1: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2: ");
            var numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3: ");
            var numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("4: ");
            var numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("5: ");
            var numero5 = int.Parse(Console.ReadLine());
            ApresentarMedia2(numero1, numero2, numero3, numero4, numero5);
        }
        public static void ApresentarMedia2(int numero1, int numero2, int numero3, int numero4, int numero5)
        {
            Console.WriteLine(numero1 + " / " + numero2 + numero3 + " / " + numero4 + " / " + numero5+ "= " + (numero1 / numero2 / numero3 /numero4 /numero5 ));

        }

        public static void Exercicio9()
        {
            Console.WriteLine("qual o numero?");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero5 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero6 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero7 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero8 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
            var numero9 = int.Parse(Console.ReadLine());
            Console.WriteLine("qual o numero?");
        }
        public static void ApresentarMedia3(int numero1, int numero2, int numero3, int numero4, int numero5, int numero6, int numero7, int numero8, int numero9, int numero10)
        {
            Console.WriteLine(numero1 + " / " + numero2 + numero3 + " / " + numero4 + " / " + numero5 + "= " + numero6 + " / "+ (numero1 / numero2 / numero3 / numero4 / numero5));
        }
    }


}











