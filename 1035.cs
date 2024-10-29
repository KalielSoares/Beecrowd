using System;

class URI {

    static void Main(string[] args) {

        string[] entry = Console.ReadLine().Split(' ');

        int A = int.Parse(entry[0]);
        int B = int.Parse(entry[1]);
        int C = int.Parse(entry[2]);
        int D = int.Parse(entry[3]);

        if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0) {
            Console.WriteLine("Valores aceitos");
        }
        else {
            Console.WriteLine("Valores nao aceitos");
        }
    }
}