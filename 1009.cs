using System;

class URI {

    static void Main(string[] args) {

        string name = Console.ReadLine();
        double salary = double.Parse(Console.ReadLine());
        double comission = double.Parse(Console.ReadLine());


        double total = comission * 0.15;
        double salaryB = salary + total;

        Console.WriteLine($"TOTAL = R$ {salaryB:F2}");

    }

}