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
        var lista = new List<string> { "Pedro", "Lucas", "Cavalcante" };

        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);
        }
    }
}