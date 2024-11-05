
namespace beecrowd{
    class URI {

        static void Main(string[] args) {

            string[] media = Console.ReadLine().Split(' ');
            double N1 = double.Parse(media[0]);
            double N2 = double.Parse(media[1]);
            double N3 = double.Parse(media[2]);
            double N4 = double.Parse(media[3]);

            double meedia = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10;

            Console.WriteLine($"Media: {Math.Round(meedia, 1).ToString("0.0")}");

            if (meedia >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (meedia >= 5.0 & meedia <= 6.9) {
                Console.WriteLine("Aluno em exame.");
                double exame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {exame.ToString("0.0")}");
                double newMedia = (exame + meedia) / 2;
                if (newMedia >= 5) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {newMedia:F1}");
                }
                else {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {newMedia:F1}");
                }
            }
            else {
                Console.WriteLine("Aluno reprovado.");
            }
        }
    }
}
