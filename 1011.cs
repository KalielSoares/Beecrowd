using System;

class URI {

    static void Main(string[] args) {

        double R = double.Parse(Console.ReadLine());
        double total = (4.0 / 3.0) * 3.14159 * Math.Pow(R, 3);
        Console.WriteLine($"VOLUME = {total:F3}");

    }

}