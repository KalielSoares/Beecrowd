using System;

class URI {

    static void Main(string[] args) {

        float num = float.Parse(Console.ReadLine());

        if (num >= 0 && 25 >= num) {
            Console.WriteLine("Intervalo [0,25]");
        }
        else if (num > 25 && 50 >= num) {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if (num > 50 && 75 >= num) {
            Console.WriteLine("Intervalo (50,75]");
        }
        else if (num > 75 && 100 >= num) {
            Console.WriteLine("Intervalo (75,100]");
        }
        else {
            Console.WriteLine("Fora de intervalo");
        }


    }

}