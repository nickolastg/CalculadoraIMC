using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua altura em metros. Ex: 1,7");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com seu peso em kg. Ex: 69,4");
            double peso = Convert.ToDouble(Console.ReadLine());

            Individuo i1 = new Individuo(nome, altura, peso);
            Console.WriteLine("{0}, sua altura é {1}m e seu peso {2}kg", i1.Nome, i1.Altura, i1.Peso);

            Console.WriteLine("Seu IMC é {0}", i1.Imc);
            Console.WriteLine(i1.Classifica());
            Console.WriteLine(i1.PesoNecessario());
        }
    }
}