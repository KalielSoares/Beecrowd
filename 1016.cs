using System;

class URI {

    static void Main(string[] args) {

        int input = int.Parse(Console.ReadLine());

        int distance = (60 * input) / 30;

        Console.WriteLine($"{distance} minutos");


    }

}