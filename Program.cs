class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Entrez votre salaire brut : ");
        if (int.TryParse(Console.ReadLine(), out int salary))
        {
            Console.WriteLine("Entrez la taxe : ");
            if (int.TryParse(Console.ReadLine(), out int tax))
            {
                int salaryNet = CalculateSalaryNet(salary,tax);
                Console.WriteLine("Si votre salaire est de " + salary + " et la taxe de " + tax + " alors votre salaire net est de " + salaryNet);
                if (salary > 50000)
                {
                    Console.WriteLine("Vous devriez faire des dons pour diminuer vos impots");
                } else if (salaryNet < 1500)
                {
                    Console.WriteLine("C'est normal pour un alternant :)");
                } else if (salary < 40000 && salary > 30000)
                {
                    Console.WriteLine("Tu devrais prendre une formation bac+5 en dev au CESI pour passer ingénieur");
                }
            } else
            {
                Console.WriteLine("Entrez la taxe en nombre !!!");
            }
        } else
        {
            Console.WriteLine("Entrez le salaire en nombre !!!");
        }
    }


    static int CalculateSalaryNet(int salary, int tax)
    {
        return (salary * (1 - tax / 100)) / 12;
    }    
}