public class Individuo
{
    public string Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get => (Peso / (Altura * Altura)); }
    public double PesoIdeal { get; set; }

    public Individuo()
    {
        Nome = "";
        Altura = 0;
        Peso = 0;
    }

    public Individuo(string nome, double altura, double peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public string Classifica()
    {
        if (Imc >= 0)
        {
            if (Imc <= 18.5)
            {
                return "Classificação Imc: Baixo peso";
            }
            else if (Imc > 18.5 && Imc < 25)
            {
                return "Classificação Imc: Peso Normal";
            }
            else if (Imc >= 25 && Imc < 30)
            {
                return "Classificação Imc: Sobrepeso";
            }
            else if (Imc >= 30 && Imc < 35)
            {
                return "Classificação Imc: Obesidade grau I";
            }
            else if (Imc >= 35 && Imc < 40)
            {
                return "Classificação Imc: Obesidade grau II";
            }
            else if (Imc >= 40)
            {
                return "Classificação Imc: Obesidade grau III";
            }
        }

        throw new Exception ("Os valores inseridos são inválidos");
    }

    public string PesoNecessario()
    {
        if (Imc <= 18.5 && Imc >= 0)
        {
            PesoIdeal = 18.5 * (Altura * Altura);
            return "Você precisa ganhar " + Math.Round(PesoIdeal - Peso, 1) + "kg para alcançar o peso ideal";
        }

        if (Imc >= 25)
        {
            PesoIdeal = 24.9 * (Altura * Altura);
            return "Você precisa perder " + Math.Round(Peso - PesoIdeal, 1) + "kg para alcançar o peso ideal";
        }

        return "Você está no peso ideal";
    }
}