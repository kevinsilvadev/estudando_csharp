using System;
using System.Collections.Generic;

namespace treino_csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Calculadora
            double num1, num2;

            Console.WriteLine("Entre com o primeiro numero: ");
            num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com segundo numero: ");
            num2 = Double.Parse(Console.ReadLine());

            

            double sum = num1 + num2;
            double mult = num1 * num2;
            double divi = num1 / num2;
            double sub = num1 - num2;

            Console.Write("\nA soma entre os dois numeros é: " + sum);
            Console.Write("\nA multiplicação entre os dois numeros é: " + mult);
            Console.Write("\nA divisão entre os dois numeros é: " + divi);
            Console.Write("\nA sub entre os dois numeros é: " + sub);
            */




            /* Tabuada
            Console.WriteLine("Entre com o numero para saber a tabuada: ");
            int num = Int16.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++) {
                int tb = i * num;
                Console.WriteLine(num + " X " + i + " = " + tb);
            }

            */

            /* Cadastrando estudantes na lista

            List<Students> list = new List<Students>();


            Console.WriteLine("Quantos estudantes desejam cadastrar? ");
            int n = Int16.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

            Console.WriteLine("Digite o #" + i + " estudante ");

            Console.WriteLine("Name: ");

            String name = Console.ReadLine();

            Console.WriteLine("Email: ");
            String email = Console.ReadLine();

            Console.WriteLine("Phone");
            int phone = Int32.Parse(Console.ReadLine());

            list.Add( new Students(name, email, phone));
        }


            foreach (Students s in list) {
                Console.WriteLine(s);

            } 
            */

            Tabuada(5);
            Sum(9, 3);

        }

        public static void Tabuada(int num)
        {

            for (int i = 1; i <= 10; i++)
            {
                int tb = num * i;
                Console.WriteLine(num + " x " + i + " = " + tb);
            }
        }

        public static void Sum(int num1, int num2)
        {

            float sum = num1 + num2;
            Console.WriteLine($"A soma entre o numero {num1} e o numero {num2} é: {sum} ");


        }


    }
}
