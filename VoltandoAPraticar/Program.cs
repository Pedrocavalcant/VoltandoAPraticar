namespace VoltandoAPraticar;

class Program
{
    enum Cores
    {
        Vermelho,
        Azul,
        Amarelo,
        Verde,
        Roxo,
        Laranja
    }

    static void Main()
    {
        var numero = 0;

        while (numero < 100) 
        {
            if (numero == 5)
                break;

            Console.WriteLine(numero);

            numero++;
        }

        Console.WriteLine("Continua aqui");
        Console.WriteLine(numero);
    }
}