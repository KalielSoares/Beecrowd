using System;
using System.Collections.Generic;

class URI {

    static void Main(string[] args) {


        List<int> numeros = new List<int>();
        for (int i = 0; i < 4; i++) {
            int numero = int.Parse(Console.ReadLine());
            numeros.Add(numero);
        }


        int average = ((numeros[0] * numeros[1]) - (numeros[2] * numeros[3]));

        Console.WriteLine($"DIFERENCA = {average}");
    }

}