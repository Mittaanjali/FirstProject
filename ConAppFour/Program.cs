// See https://aka.ms/new-console-template for more information

using ConAppFour;

List<Employee> employees = new List<Employee>()
 {
                new Employee() { Id = 1, Name = "Vijay", Designation = "Developer", DOJ = new DateTime(2822, 11, 12) },
                new Employee() { Id = 2, Name = "Niraj", Designation = "Tester", DOJ = new DateTime(2022, 11, 12) },
                new Employee() { Id = 3, Name = "Vipul", Designation = "Manager", DOJ = new DateTime(2022, 11, 12) },
                new Employee() { Id = 4, Name = "Gagan", Designation = "Developer", DOJ = new DateTime(2023, 11, 12) },
                new Employee() { Id = 5, Name = "Simi", Designation = "Manager", DOJ = new DateTime(2023, 11, 12) },
                new Employee() { Id = 6, Name = "Ritesh", Designation = "Developer", DOJ = new DateTime(2021, 11, 12) }
};
Console.WriteLine("ID\tName\t\tDesignation\tDate of Joining");
foreach (Employee emp in employees)
{
    Console.Write(emp.Id + "\t");
    Console.Write(emp.Name + "\t\t");
    Console.Write(emp.Designation + "\t \t");
    Console.Write(emp.DOJ.ToLongDateString());
    Console.WriteLine("\n");
}