namespace Fundamentos_de_C_Sharp.Welcomes;
public static class Welcome
{
    public static string Name()
    {

        Console.WriteLine("Insira seu primeiro nome abaixo:");
        string name = Console.ReadLine();

        Console.WriteLine("Insira seu sobrenome abaixo:");
        string lastname = Console.ReadLine();

        string fullname = (name + ' ' + lastname);

        return fullname;
    }

    public static void Message(string fullname) => Console.WriteLine($"Olá, {fullname}! Seja muito bem-vindo!");
   

}
