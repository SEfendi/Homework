internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Adiniz nedir");
        string Name = Console.ReadLine();
        Console.WriteLine("Soyadiniz nedir");
        string Surname = Console.ReadLine();
        Console.WriteLine("Nece yasiniz var ?");
        string Age = Console.ReadLine();
        Console.WriteLine(Name + " " + Surname + " " + Age);

    }
}