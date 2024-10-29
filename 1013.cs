using System;

class URI {

    static void Main(string[] args) {

        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);

        if (C > B && C > A) {
            Console.WriteLine($"{C} eh o maior");
        }
        else if (B > A && B > C) {
            Console.WriteLine($"{B} eh o maior");
        }
        else {
            Console.WriteLine($"{A} eh o maior");
        }

    }

}