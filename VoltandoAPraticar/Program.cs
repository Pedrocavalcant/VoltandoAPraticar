namespace VoltandoAPraticar;

class Program
{
    static void Main()
    {
        Teste(5);
    }

    static string Teste(int numero)
    {
        Console.WriteLine("Teste1");

        if (numero == 5)
        {
            Console.WriteLine("Teste2");
            return "Pedro";
        }

        Console.WriteLine("Teste3");

        return "Lucas";
    }
}