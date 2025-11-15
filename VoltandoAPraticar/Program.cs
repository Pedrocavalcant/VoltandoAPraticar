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
        int numero = 1;


        string resposta = numero switch
        {
            > 0 and < 3 => "entre 0 e 3",
            _ => "Nenhuma das opcoes anteriores"
        };

        Console.WriteLine(resposta);
    }
}