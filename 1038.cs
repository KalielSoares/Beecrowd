using System;

class URI {

    static void Main(string[] args) {

        string[] pedido = Console.ReadLine().Split(' ');
        int id = int.Parse(pedido[0]);
        int quantity = int.Parse(pedido[1]);

        double value;

        switch (id) {
            case 1:
                value = quantity * 4.00;
                Console.WriteLine($"Total: R$ {value:F2}");
                break;

            case 2:
                value = quantity * 4.50;
                Console.WriteLine($"Total: R$ {value:F2}");
                break;
            case 3:
                value = quantity * 5.00;
                Console.WriteLine($"Total: R$ {value:F2}");
                break;
            case 4:
                value = quantity * 2.00;
                Console.WriteLine($"Total: R$ {value:F2}");
                break;
            case 5:
                value = quantity * 1.50;
                Console.WriteLine($"Total: R$ {value:F2}");
                break;
        }

    }


}
