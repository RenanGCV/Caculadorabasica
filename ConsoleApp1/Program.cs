using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, me chamo Robson seu assiste de calculo.");
            Inicio();
        }

        static void Inicio()
        {
            
            Console.WriteLine("Escolha qual tipo de conta quer realizar. \n 1. Soma \n 2.Subtração \n 3. Multiplicação \n 4. Divisão");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Você selecionou soma. Escolha um número");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Selecione o segundo número");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int soma = numero1 + numero2;
                Console.WriteLine("Seu resultado é " + soma);
                Console.WriteLine("Deseja realizar outra operação? Digite sim ou nao");
                string resposta1 = Convert.ToString(Console.ReadLine());
                if (resposta1.Equals("sim"))
                {
                    Inicio();
                }

                else if (resposta1.Equals("nao"))
                {
                    Console.WriteLine("Ok, Tenha um bom dia!");
                }
            }

            if (op == 2)
            {
                Console.WriteLine("Você selecionou subtação. Escolha um número");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Selecione o segundo número");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int subtracao = numero1 - numero2;
                Console.WriteLine("Seu resultado é " + subtracao);
                Console.WriteLine("Deseja realizar outra operação? Digite sim ou nao");
                string resposta1 = Convert.ToString(Console.ReadLine());
                if (resposta1.Equals("sim"))
                {
                    Inicio();
                }

                else if (resposta1.Equals("nao"))
                {
                    Console.WriteLine("Ok, Tenha um bom dia!");
                }
            }

            if (op == 3)
            {
                Console.WriteLine("Você selecionou multiplicação. Escolha um número");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Selecione o segundo número");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int mult = numero1 * numero2;
                Console.WriteLine("Seu resultado é " + mult);
                Console.WriteLine("Deseja realizar outra operação? Digite sim ou nao");
                string resposta1 = Convert.ToString(Console.ReadLine());
                if (resposta1.Equals("sim"))
                {
                    Inicio();
                }

                else if (resposta1.Equals("nao"))
                {
                    Console.WriteLine("Ok, Tenha um bom dia!");
                }

            }

            if (op == 4)
            {
                Console.WriteLine("Você selecionou divisão. Escolha um número");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Selecione o segundo número");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                int div = numero1 / numero2;
                Console.WriteLine("Seu resultado é " + div);
                Console.WriteLine("Deseja realizar outra operação? Digite sim ou nao");
                string resposta1 = Convert.ToString(Console.ReadLine());
                if (resposta1.Equals("sim"))
                {
                    Inicio();
                }

                else if (resposta1.Equals("nao"))
                {
                    Console.WriteLine("Ok, Tenha um bom dia!");
                }
            }
        }
    }
}