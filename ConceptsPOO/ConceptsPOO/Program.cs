
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

Console.WriteLine(employee1);
Console.WriteLine(employee2);