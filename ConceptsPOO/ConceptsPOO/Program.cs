
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 23400.45M
};

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Patricia",
    LastName = "Perez",
    BirthDate = new Date(1995, 7, 23),
    HiringDate = new Date(2022, 3, 5),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F

};

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Gerald",
    LastName = "Then",
    BirthDate = new Date(1995, 7, 30),
    HiringDate = new Date(2020, 3, 5),
    IsActive = true,
    Hours = 123.5F,
    HourValue = 1232.56M

};

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Adris",
    LastName = "Polanco",
    BirthDate = new Date(1994, 12, 24),
    HiringDate = new Date(2020, 3, 7),
    IsActive = true,
    Base = 12300.45M,
    Sales = 58000000M,
    CommissionPercentaje = 0.015F

};

//Console.WriteLine(employee1);
//Console.WriteLine(employee2);
//Console.WriteLine(employee3);
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2,employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                                  ===============");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 63000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Premium",
    Id = 2,
    Price = 7000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);