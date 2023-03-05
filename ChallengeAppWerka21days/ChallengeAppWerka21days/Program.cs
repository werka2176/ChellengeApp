using ChellengeAppWerka21days;

var employee = new Employee("Anna", "Cieszkowska");
employee.AddGrade("Werka");
employee.AddGrade("4000");
employee.AddGrade(26);
employee.AddGrade(21);
employee.AddGrade(20);

Console.WriteLine("Wyniki dla ForEach:");
var statistics = employee.GetStatisticsForEach();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

