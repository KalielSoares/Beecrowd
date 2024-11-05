using System;

class URI {

    static void Main(string[] args) {

        string[] num = Console.ReadLine().Split(' ');
        double x = double.Parse(num[0]);
        double y = double.Parse(num[1]);

        if (x > 0 & y > 0) {
            Console.WriteLine("Q1");
        }
        else if ((x > 0 & y < 0)) {
            Console.WriteLine("Q4");
        }
        else if ((x < 0 & y > 0)) {
            Console.WriteLine("Q2");
        }
        else if ((x < 0 & y < 0)) {
            Console.WriteLine("Q3");
        }
        else if (x == 0 & y != 0) {
            Console.WriteLine("Eixo Y");
        }
        else if ((x != 0 & y == 0)) {
            Console.WriteLine("Eixo X");
        }
        else {
            Console.WriteLine("Origem");
        }
    }
