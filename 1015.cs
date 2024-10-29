using System;

class URI {

    static void Main(string[] args) {

        string[] A1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(A1[0]);
        double y1 = double.Parse(A1[1]);


        string[] A2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(A2[0]);
        double y2 = double.Parse(A2[1]);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


        Console.WriteLine($"{distance:F4}");

    }

}