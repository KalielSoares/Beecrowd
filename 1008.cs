using System;

class URI {

    static void Main(string[] args) {

        int ID = int.Parse(Console.ReadLine());
        int hours = int.Parse(Console.ReadLine());
        float salary = float.Parse(Console.ReadLine());

        float total = hours * salary;

        Console.WriteLine($"NUMBER = {ID}\nSALARY = U$ {total:F2}");
    }

}