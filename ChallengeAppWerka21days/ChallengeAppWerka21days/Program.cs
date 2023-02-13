using ChellengeAppWerka21days;

var employee = new Employee("Anna", "Cieszkowska");
employee.AddGrade("Werka");
employee.AddGrade("4000");
employee.AddGrade(26);
employee.AddGrade(21);
employee.AddGrade(20);

Console.WriteLine("Wyniki dla ForEach:");
var statistics1 = employee.GetStatisticsForEach();
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");

Console.WriteLine("Wyniki dla For:");
var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}");

Console.WriteLine("Wyniki dla DoWhile:");
var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}");

Console.WriteLine("Wyniki dla While:");
var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Min: {statistics4.Min}");
