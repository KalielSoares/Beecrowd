using System;

class URI {

    static void Main(string[] args) {

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double average = (((a * 3.5) + (b * 7.5)) / 11.0);

        Console.WriteLine($"MEDIA = {average:F5}");

    }

}