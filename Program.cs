class Program
{
    static void Main(string[] args)
    {
        string[] month;
        month = new string[13];
        month[1] = "Janvier";
        month[2] = "Février";
        month[3] = "Mars";
        month[4] = "Avril";
        month[5] = "Mai";
        month[6] = "Juin";
        month[7] = "Juillet";
        month[8] = "Août";
        month[9] = "Septembre";
        month[10] = "Octobre";
        month[11] = "Novembre";
        month[12] = "Décembre";
        Console.WriteLine("Entrez votre salaire mensuel : ");
        int salary = int.Parse(Console.ReadLine());
        foreach (string mois in month)
        {
            double salaryMensuel = salary;
            switch (mois)
            {
                case "Décembre":
                    salaryMensuel *= 1.1;
                    break;
                case "Août":
                    salaryMensuel = 0;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Salaire pour " + mois + " : " + salaryMensuel);
        }
    }












    static int CalculateSalaryNet(int salary, int tax)
    {
        return (salary * (1 - tax / 100)) / 12;
    }

    static void Salaire()
    {
        Console.WriteLine("Entrez votre salaire brut : ");
        if (int.TryParse(Console.ReadLine(), out int salary))
        {
            Console.WriteLine("Entrez la taxe : ");
            if (int.TryParse(Console.ReadLine(), out int tax))
            {
                int salaryNet = CalculateSalaryNet(salary, tax);
                Console.WriteLine("Si votre salaire est de " + salary + " et la taxe de " + tax + " alors votre salaire net est de " + salaryNet);
                switch (salary)
                {
                    case > 50000:
                        Console.WriteLine("Vous devriez faire des dons pour diminuer vos impots");
                        break;
                    case < 1500*12:
                        Console.WriteLine("C'est normal pour un alternant :)");
                        break;
                    case < 40000:
                        if (salary > 30000) {
                            Console.WriteLine("Tu devrais prendre une formation bac+5 en dev au CESI pour passer ingénieur");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrez la taxe en nombre !!!");
            }
        }
        else
        {
            Console.WriteLine("Entrez le salaire en nombre !!!");
        }
    }
}