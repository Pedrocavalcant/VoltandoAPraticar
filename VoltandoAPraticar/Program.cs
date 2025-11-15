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
        var dicionario = new Dictionary<string, string>();

        dicionario.Add("Nome1", "Pedro");
        dicionario.Add("Nome2", "Lucas");
        dicionario.Add("Nome3", "Cavalcante");

        foreach (var i in dicionario)
        {
            Console.WriteLine(i);
        }
    }
}