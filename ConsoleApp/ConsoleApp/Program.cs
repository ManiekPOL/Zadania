using ConsoleApp;

var employee = new Employee("Adam", "Mork");
employee.AddGrade("5");
employee.AddGrade(2.8);
employee.AddGrade(2);
var statistics = employee.GetStatistics();

Console.WriteLine("Pracownik Adam Mork ");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
