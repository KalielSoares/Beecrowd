using System;

class URI {

    static void Main(string[] args) {

        double valor = double.Parse(Console.ReadLine());

        double[] notas = { 100, 50, 20, 10, 5, 2 };
        double[] moedas = { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };

        Console.WriteLine("NOTAS:");
        foreach (var nota in notas) {
            double quantidadeDeNotas = (valor / nota);
            Console.WriteLine($"{Math.Floor(quantidadeDeNotas).ToString("0")} nota(s) de R$ {nota:F2}");
            valor %= nota;
        }

        Console.WriteLine("MOEDAS:");
        for (var i = 0; i < moedas.Length; i++) {
            int quantidadeDeMoedas = (int)(valor / moedas[i]);
            Console.WriteLine($"{quantidadeDeMoedas.ToString("0")} moeda(s) de R$ {moedas[i]:F2}");
            valor -= quantidadeDeMoedas * moedas[i];
            valor = Math.Round(valor, 2);
        }
    }

}