using ChellengeAppWerka21days;

var employee = new Employee("Anna", "Cieszkowska");
employee.AddGrade(15);
employee.AddGrade(4);
employee.AddGrade(26);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");