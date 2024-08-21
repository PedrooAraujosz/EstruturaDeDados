using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {

        List<string> frutas = new List<string>();

        frutas.Add("Maçã");
        frutas.Add("Uva");
        frutas.Add("Pera");
        frutas.Add("Kiwi");

        Console.WriteLine("Imprimindo Minha Lista: ");
        foreach (string fruit in frutas)
        { Console.WriteLine(fruit); }

        Console.WriteLine();
        Console.WriteLine("===========================");

        //Trabalhando com fila 
        /*Criar fila (Queue)*/

        Queue<string> filaBanco = new Queue<string>();

        filaBanco.Enqueue("Pedro");
        filaBanco.Enqueue("luiz");
        filaBanco.Enqueue("Melissa");
        filaBanco.Enqueue("Wilian");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        filaBanco.Dequeue();

        Console.WriteLine();
        Console.WriteLine("===========================");


    }
}