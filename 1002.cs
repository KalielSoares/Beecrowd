using System;

class URI {

    static void Main(string[] args) {

        double radius = double.Parse(Console.ReadLine());
        double area = 3.14159 * (radius * radius);

        Console.WriteLine($"A={area:F4}");
    }
}
