using System;

class URI {

    static void Main(string[] args) {

        string[] valores = Console.ReadLine().Split(' ');
        int A = int.Parse(valores[0]);
        int B = int.Parse(valores[1]);
        float C = float.Parse(valores[2]);

        string[] valores2 = Console.ReadLine().Split(' ');
        int D = int.Parse(valores2[0]);
        int E = int.Parse(valores2[1]);
        float F = float.Parse(valores2[2]);

        float total = (B * C) + (E * F);


        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
    }

}