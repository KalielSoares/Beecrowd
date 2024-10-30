using System;

class URI {

    static void Main(string[] args) {

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());
        double E = double.Parse(Console.ReadLine());

        double[] Array = { A, B, C, D, E };
        int numPositivos = 0;
        int numNegativos = 0;
        int numPar = 0;
        int numImpar = 0;

        foreach (int par in Array) {
            if (par % 2 == 0) {
                numPar++;
            }
        }

        foreach (int negativo in Array) {
            if (negativo < 0) {
                numNegativos++;
            }
        }

        foreach (int positivos in Array) {
            if (positivos > 0) {
                numPositivos++;
            }
        }

        foreach (int impar in Array) {
            if (impar % 2 != 0) {
                numImpar++;
            }
        }

        Console.WriteLine($"{numPar} valor(es) par(es)\n{numImpar} valor(es) impar(es)\n{numPositivos} valor(es) positivo(s)\n{numNegativos} valor(es) negativo(s)");

    }
}