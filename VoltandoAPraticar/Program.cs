using System.Globalization;

namespace VoltandoAPraticar;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu nome:");
        var nome = Console.ReadLine();
        Console.WriteLine($"Ola, {nome}! Seja muito bem-vindo!");


        Console.WriteLine("Digite o seu nome:");
        var nome2 = Console.ReadLine();
        Console.WriteLine("Digite o seu sobrenome:");
        var sobrenome = Console.ReadLine();
        Console.WriteLine($"Ola, {nome2} {sobrenome}! seja muito bem-vindo!");

        Console.WriteLine("Digite o primeiro numero:");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segunto numero:");
        double numero2 = double.Parse(Console.ReadLine());

        double soma = numero1 + numero2;
        Console.WriteLine(soma);
        double subtracao = numero1 - numero2;
        Console.WriteLine(subtracao);
        double multiplicacao = numero1 * numero2;
        Console.WriteLine(multiplicacao);
        double divisao = numero1 / numero2;
        Console.WriteLine(divisao);
        double media = (numero1 + numero2) / 2;
        Console.WriteLine(media);

        Console.WriteLine("Digite uma palavra, que irei contabilizar a quantidade de caracteres do mesmo, nao contarei com espaços:");
        var palavra = Console.ReadLine();
        Console.WriteLine("Caracteres digitados: " + palavra.Length);
        var palavraSemEspaco = palavra.Replace(" ", "");
        Console.WriteLine("Caracteres digitados, sem contar com os espacos: " + palavraSemEspaco.Length);

        Console.WriteLine("Digite uma placa de carro com 7 caracteres (Exemplo: ABC1234):");
        var placa = Console.ReadLine().ToUpper();

        if (placa.Length != 7)
        {
            Console.WriteLine("Placa invalida! Verifique se esta com 7 caracteres.");
            return;
        }

        bool letrasValidas = placa.Take(3).All(char.IsLetter);
        bool numerosValidos = placa.Skip(3).Take(4).All(char.IsDigit);

        if (letrasValidas && numerosValidos)
        {
            Console.WriteLine("Placa valida!");
        }
        else
        {
            Console.WriteLine("Placa invalida! Verifique o formato correto (Exemplo: ABC1234).");
        }

        DateTime agora = DateTime.Now;
        CultureInfo cultura = new CultureInfo("pt-BR");

        Console.WriteLine("Formatos de data");

        Console.WriteLine("Formado completo:");
        Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", cultura));
        Console.WriteLine();

        Console.WriteLine("Apenas a data (dd/MM/yyyy):");
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));
        Console.WriteLine();

        Console.WriteLine("Apenas a hora (24h):");
        Console.WriteLine(agora.ToString("HH:mm:ss"));
        Console.WriteLine();

        Console.WriteLine("Data com mes por extenso:");
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", cultura));

    }
}