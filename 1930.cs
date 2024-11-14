using System;

class URI {

    static void Main(string[] args) {

        string[] Entry = Console.ReadLine().Split(' ');

        int t1 = int.Parse(Entry[0]);
        int t2 = int.Parse(Entry[1]);
        int t3 = int.Parse(Entry[2]);
        int t4 = int.Parse(Entry[3]);

        int total = (t1 - 1) + (t2 - 1) + (t3 - 1) + t4;


        Console.WriteLine($"{total}");
    }
}