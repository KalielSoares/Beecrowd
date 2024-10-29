using System;

class URI {

    static void Main(string[] args) {

        int A = int.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());

        double consumo = A / B;
        Console.WriteLine($"{consumo:F3} km/l");

    }

}