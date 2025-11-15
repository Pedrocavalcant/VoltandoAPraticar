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
        var numero = 10;

        do 
        {
            Console.WriteLine(numero + " no 10 vai sair do loop");

            numero++;
        }
        while (numero < 10) ;
        Console.WriteLine("Saiu");
        Console.WriteLine(numero);
    }
}