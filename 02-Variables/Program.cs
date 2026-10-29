namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
        string nombre;
        int edad;

        Console.WriteLine("Ingresa tu nombre:");
        nombre = Console.ReadLine();

        Console.WriteLine("Ingresa tu edad:");
        edad = int.Parse(Console.ReadLine());

        Console.WriteLine($"Hola {nombre}, tienes {edad} años.");
    }

}
