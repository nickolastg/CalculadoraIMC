using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura em metros. Ex: 1,70");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Entre com seu peso em metros. Ex: 69,4");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);
            double pesoIdeal;

            if (imc >= 0)
            {
                Console.WriteLine("{0}, sua altura é {1} e seu peso {2}", nome, altura, peso);
                Console.WriteLine("Seu IMC é {0}", imc);

                if (imc <= 18.5)
                {
                    pesoIdeal = 18.5 * (altura * altura);
                    Console.WriteLine("Classificação IMC: Baixo peso");
                    Console.WriteLine("Você precisa ganhar {0}kg para alcançar o peso ideal", Math.Round(pesoIdeal - peso, 1));
                }
                else if (imc >= 18.6 && imc <= 24.9)
                {
                    Console.WriteLine("Classificação IMC: Peso Normal");
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    Console.WriteLine("Classificação IMC: Sobrepeso");
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    Console.WriteLine("Classificação IMC: Obesidade grau I");
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    Console.WriteLine("Classificação IMC: Obesidade grau II");
                }
                else if (imc >= 40)
                {
                    Console.WriteLine("Classificação IMC: Obesidade grau III");
                }

                if (imc >= 25)
                {
                    pesoIdeal = 24.9 * (altura * altura);
                    Console.WriteLine("Você precisa perder {0}kg para alcançar o peso ideal", Math.Round(peso - pesoIdeal, 1));
                }
            }
            else Console.WriteLine("Valores inválidos para calculo");
        }
    }
}