// zadanie domowe dzień 4 podejście 1
string name1 = "Ewa";
string name2 = "Weronika";
string name3 = "Maksymilian";

int age1 = 40;
int age2 = 28;
int age3 = 16;

Char sex1 = 'K';
Char sex2 = 'M';

string result1 = name1 + age1 + sex1;
string result2 = name2 + age2 + sex1;
String result3 = name3 + age3 + sex2;

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);

if (name1 == "Ewa" && age1 < 30)
{
    Console.WriteLine("Jest tu Ewa poniżej przed trzydziestką");
}
else
{
    Console.WriteLine("Nie ma tu Ewy przed trzydziestką");
}

if (name2 == "Weronika" && age2 == 28)
{
    Console.WriteLine(result2 + "Weronika ma 28 lat");
}
else
{
    Console.WriteLine("Nie ma tu takiej Weroniki");
}

if (sex2 == 'M' && name3 == "Robert" && age3 < 18)
{
    Console.WriteLine("Jest tu niepełnoletni chłopak");
}
else
{
    Console.WriteLine("Nie ma tu niepełnoletniego Roberta");
}