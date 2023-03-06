using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Entrez votre salaire brut : ");
        int salary = int.Parse(Console.ReadLine());
        Console.WriteLine("Entrez la taxe : ");
        int tax = int.Parse(Console.ReadLine());
        Console.WriteLine("Votre salaire est de : " + salary);
        Console.WriteLine("La taxe est de : " + tax);

        Console.WriteLine("Si votre salaire est de " + salary + " et la taxe de " + tax + " alors votre salaire net est de " + AfficherSalaireNet(salary,tax));
    }
    static int AfficherSalaireNet(int salary, int tax)
    {
        return (salary * (1 - tax / 100)) / 12;
    }    
}