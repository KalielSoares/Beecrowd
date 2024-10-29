using System;
using System.Globalization;

class URI {

    static void Main(string[] args) {

        double A, B, C;
        string[] valores = Console.ReadLine().Split(' ');

        A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double delta = (Math.Pow(B, 2.0) - 4.0 * A * C);

        if (delta < 0 || A == 0) {
            Console.WriteLine($"Impossivel calcular");
        }
        else {
            double x1 = ((-B + Math.Sqrt(delta)) / (2.0 * A));
            double x2 = ((-B - Math.Sqrt(delta)) / (2.0 * A));
            Console.WriteLine($"R1 = {x1:F5}\nR2 = {x2:F5}");
        }
    }


}
