using System;

class URI {

    static void Main(string[] args) {

        int value = int.Parse(Console.ReadLine());

        int years = value / 365;
        int month = (value % 365) / 30;
        int days = (value % 365) % 30;

        Console.WriteLine($"{years} ano(s)\n{month} mes(es)\n{days} dia(s)");

    }

}