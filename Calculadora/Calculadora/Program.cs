using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Menu() != 0)
            {

            }
        }

        static int Menu()
        {
            
            Console.WriteLine("Olá, seja bem-vindo(a), Escolha uma das opções abaixo: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("------------");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 0: break;
                    default: Console.Clear(); Console.WriteLine("A opção selecionada não é válida. Selecione uma das opções apresentadas"); break;
            }
            return res;
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da subtração é: {resultado}");
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            if(valor2 == 0)
            {
                Console.WriteLine("Não é possível realizar divisão por 0. Tente novamente");
                return;
            }

            float resultado = valor1 / valor2;

            

            Console.WriteLine($"O resultado da divisão é: {resultado}");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            float resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        }
    }
}