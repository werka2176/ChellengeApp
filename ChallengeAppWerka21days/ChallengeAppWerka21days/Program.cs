// Zadanie domowe dzień 5 podejście 1

int number = 291294;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

List<char> liczby = new List<char>();
liczby.Add('0');
liczby.Add('1');
liczby.Add('2');
liczby.Add('3');
liczby.Add('4');
liczby.Add('5');
liczby.Add('6');
liczby.Add('7');
liczby.Add('8');
liczby.Add('9');


Console.WriteLine("Liczba do analizy: " + number);

foreach (var singular in liczby)
{
    int count = 0;
    foreach (var x in letters)
    {
        if (singular == x) count++;
    }
    Console.WriteLine(singular + "=>" + count);
}


