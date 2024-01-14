using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Obliczanie wartości funkcji y = √(3^2) * x dla x od 0 do 10:");

        for (int x = 0; x <= 10; x++)
        {
            double y = Math.Sqrt(3 * 3) * x;
            Console.WriteLine($"Dla x = {x}, y = {y}");
        }

        Console.ReadLine(); // Zatrzymuje konsolę przed zamknięciem
    }
}
