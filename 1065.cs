using System;

class URI {

    static void Main(string[] args) {

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());
        double E = double.Parse(Console.ReadLine());
        double F = double.Parse(Console.ReadLine());

        double[] Array = { A, B, C, D, E, F };
        int numPositivos = 0;

        foreach (int postivo in Array) {
            if (postivo % 2 == 0) {
                numPositivos++;
            }
        }

        Console.WriteLine($"{numPositivos} valores pares");

    }


}