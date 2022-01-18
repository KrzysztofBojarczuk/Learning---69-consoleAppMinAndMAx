// See https://aka.ms/new-console-template for more information





Console.WriteLine("Wprowadź liczbę wydatków: ");
int userInput = int.Parse(Console.ReadLine());
decimal[] tablica = new decimal[userInput];

for (int i = 0; i < tablica.Length; i++)
{
    Console.WriteLine($"Wprwoadź wydatek nr: {i+1}:");
    tablica[i] = decimal.Parse(Console.ReadLine());
}
Console.WriteLine("==");
decimal max = tablica[0];
decimal min = tablica[0];
foreach (var item in tablica)
{
    if (item > max)
    {
        max = item;
    }
    if (item < min)
    {
        min = item;
    }
}
Console.WriteLine($"Twój największy wydatek to: {max.ToString("c")}");
Console.WriteLine($"Twój najmniejszy wydatek to: {min.ToString("c")}");
for (int i = 0; i < tablica.Length; i++)
{
    for (int j = i +1; j < tablica.Length; j++)
    {
        if (tablica[i] > tablica[j])
        {
            decimal result = tablica[i];
            tablica[i] = tablica[j];
            tablica[j] = result;
        }
    }
}
Console.WriteLine("Posortowana lista: ");
foreach (var item in tablica)
{
    Console.WriteLine(item.ToString("c"));
}
var sum = tablica.Sum();
Console.WriteLine("Suma twoich wydatków to: " + sum.ToString("c"));