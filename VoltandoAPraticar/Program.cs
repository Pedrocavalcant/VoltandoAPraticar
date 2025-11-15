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

        while (numero < 10) 
        {
            numero++;

            if (numero == 5)
                continue;

            Console.WriteLine(numero);

        }

        Console.WriteLine("Continua aqui");
    }
}