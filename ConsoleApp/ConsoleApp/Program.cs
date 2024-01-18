using ConsoleApp;

var employee = new Employee("Adam", "Mork");
employee.AddGrade("5");
employee.AddGrade(2.8);
employee.AddGrade(2);
var statistics1 = employee.GetStatisticsWithForEach();

Console.WriteLine("Pracownik Adam Mork ");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}\n");

var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine("Pracownik Adam Mork ");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}\n");

var statistics3 = employee.GetStatisticsWithWhile();

Console.WriteLine("Pracownik Adam Mork ");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}\n");

var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine("Pracownik Adam Mork ");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}\n");