internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicacao");
        Console.WriteLine("5 - Sair do sistema");

        Console.WriteLine("----------");
        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Console.WriteLine("Opção inválida."); break;
        }



    }

    static void Soma()
    {
        Console.Clear();

        Console.WriteLine("Primeiro Valor: ");
        float v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float v2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine($"O resultado da soma é {v1 + v2}!");

        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine($"O resultado da subtracao de {v1} e {v2} é {v1 - v2}!");

        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine($"A divisão de {v1} e {v2} é {v1 / v2}!");

        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("Primeiro valor: ");
        float v1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo valor: ");
        float v2 = float.Parse(Console.ReadLine());

        Console.WriteLine(" ");

        Console.WriteLine($"A multiplicacao de {v1} e {v2} é {v1 * v2}!");

        Console.ReadKey();
        Menu();
    }
}