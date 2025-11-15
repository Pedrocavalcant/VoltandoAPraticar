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

        while (numero <= 10)
        {
            Console.WriteLine(numero + " no 10 vai sair do loop");

            numero++;
        }
        Console.WriteLine("Saiu");
    }
}