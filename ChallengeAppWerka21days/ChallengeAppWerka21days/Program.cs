using System;
using System.Reflection.Metadata;

Employee employee1 = new Employee("Anna", "Cieszkowska", 36);
Employee employee2 = new Employee("Hanna", "Szczecińska", 40);
Employee employee3 = new Employee("Norbert", "Leszkoń", 55);

employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(8);

employee2.AddScore(10);
employee2.AddScore(5);
employee2.AddScore(2);

employee3.AddScore(6);
employee3.AddScore(7);
employee3.AddScore(8);

var Result1 = employee1.Result;
var Result2 = employee2.Result;
var Result3 = employee3.Result;


if (employee1.Result >= employee2.Result && employee1.Result >= employee3.Result)
{
    Console.WriteLine($"Pracownikiem miesiąca zostaje: \n {employee1.Name} \n {employee1.Surname} \n Lat: {employee1.Age} \n osiągnął on wynik {employee1.Result} punktów");
}
else if (employee2.Result >= employee1.Result && employee2.Result >= employee3.Result)
{
    Console.WriteLine($"Pracownikiem miesiąca zostaje: \n {employee2.Name} \n {employee2.Surname} \n Lat: {employee2.Age} \n osiągnął on wynik {employee2.Result} punktów");
}
else if (employee3.Result >= employee1.Result && employee3.Result >= employee2.Result)
{
    Console.WriteLine($"Pracownikiem miesiąca zostaje: \n {employee3.Name} \n {employee3.Surname} \n Lat: {employee3.Age} \n osiągnął on wynik {employee3.Result} punktów");
}