class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Entrez votre salaire brut : ");
        if (!int.TryParse(Console.ReadLine(), out int salary))
        {
            Console.WriteLine("Ecrivez un nombre !!");
        }
        Console.WriteLine("Entrez la taxe : ");
        if (!int.TryParse(Console.ReadLine(), out int tax))
        {
            Console.WriteLine("Ecrivez un nombre !!");
        }
        Console.WriteLine("Votre salaire est de : " + salary);
        Console.WriteLine("La taxe est de : " + tax);

        Console.WriteLine("Si votre salaire est de " + salary + " et la taxe de " + tax + " alors votre salaire net est de " + CalculateSalaryNet(salary, tax));
    }


    static int CalculateSalaryNet(int salary, int tax)
    {
        return (salary * (1 - tax / 100)) / 12;
    }    
}