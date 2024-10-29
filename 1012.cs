using System;

class URI {

    static void Main(string[] args) {

        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        double triangulo = (A * C) / 2;
        double circulo = 3.14159 * Math.Pow(C, 2);
        double trapezio = ((A + B) / 2) * C;
        double quadrado = B * B;
        double retangulo = A * B;

        Console.WriteLine($"TRIANGULO: {triangulo:F3}\nCIRCULO: {circulo:F3}\nTRAPEZIO: {trapezio:F3}\nQUADRADO: {quadrado:F3}\nRETANGULO: {retangulo:F3}");

    }
