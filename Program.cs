class User
{
    public User(int id, string lastName, string firstName, int old, int salary, int tax)
    {
        this.id = id;
        this.lastName = lastName;
        this.firstName = firstName;
        this.old = old;
        this.salary = salary;
        this.tax = tax;
    }

    public int id { get; set; }
    public string lastName { get; set; }
    public string firstName { get; set; }
    public int old { get; set; }
    public int salary { get; set; }
    public int tax { get; set; }

}


class Program
{
    static void Main(string[] args)
    {
        User Remi = new User(1, "Perche", "Rémi", 19, 756, 10);
        User Romain = new User(2, "Lutigneaux", "Romain", 29, 3500, 30);
        Console.WriteLine("\nId : " + Remi.id + "\nNom de famille : " + Remi.lastName + "\nPrénom : " + Remi.firstName + "\nAge : " + Remi.old + "\nSalaire : " + Remi.salary + "\nTaxe : " + Remi.salary);
        Console.WriteLine("\nId : " + Romain.id + "\nNom de famille : " + Romain.lastName + "\nPrénom : " + Romain.firstName + "\nAge : " + Romain.old + "\nSalaire : " + Romain.salary + "\nTaxe : " + Romain.salary);
    }














    /*
    static void SalaryMonth()
    {
        string[] months;
        months = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
        Console.WriteLine("Entrez votre salaire mensuel : ");
        int salary = int.Parse(Console.ReadLine());
        foreach (string month in months)
        {
            double salaryMensuel = salary;
            if (month == months[11])
            {
                try
                {
                    Console.WriteLine("Entrez le pourcentage de la prime de noël : ");
                    double pourcentagePrime = double.Parse(Console.ReadLine());
                    salaryMensuel *= ((pourcentagePrime / 100) + 1);
                    Console.WriteLine("Salaire pour Décembre : " + salaryMensuel);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Il faut rentrer un nombre ici !!");
                }
            }
            else if (month == months[7])
            {
                salaryMensuel = 0;
            }
            else
            {
                Console.WriteLine($"Salaire pour " + month + " : " + salaryMensuel);
            }
        }
    }


    static int CalculateSalaryNet(int salary, int tax)
    {
        return (salary * (1 - tax / 100)) / 12;
    }

    static void Salary()
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
    }*/
}