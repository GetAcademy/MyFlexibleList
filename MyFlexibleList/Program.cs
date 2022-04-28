using MyFlexibleList;

/*
 * Oppsummering
 *  - fint eksempel på objektorientering
 *    - kapsle inn kompleksitet
 *    - gjøre kode mer lesbar, lettere å skjønne
 *    - gjemme bort "hvordan", fokusere på "hva"
 *  - Forstå bedre hvordan System.Collections.Generic.List virker
 *  - En liten introduksjon til Generics
 */


// Demo 4 - innebygde lister av alle typer med List<>
var namesy = new List<string>();
var numbersy = new List<int>();
while (true)
{
    Console.Write("Skriv et navn: ");
    var name = Console.ReadLine();
    namesy.Add(name);
    Console.Write("Skriv et tall: ");
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    numbersy.Add(number);
    Console.WriteLine(string.Join(", ", namesy));
    Console.WriteLine(string.Join(", ", numbersy));
}

// Demo 3 - lister av alle typer
// eksempel en med tekst og en med tall
var namesx = new FlexibleList<string>();
var numbersx = new FlexibleList<int>();
while (true)
{
    Console.Write("Skriv et navn: ");
    var name = Console.ReadLine();
    namesx.Add(name);
    Console.Write("Skriv et tall: ");
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    numbersx.Add(number);
    Console.WriteLine(namesx.GetValues());
    Console.WriteLine(numbersx.GetValues());
}

// Demo 2 - liste av tekst
var names = new FlexibleStringList();
while (true)
{
    Console.Write("Skriv et navn: ");
    var name = Console.ReadLine();
    names.AddNumber(name);
    Console.WriteLine(names.GetValues());
}

// Demo 1 - liste av tall
var numbers = new FlexibleIntList();
while (true)
{
    Console.Write("Skriv et tall: ");
    var numberStr = Console.ReadLine();
    var number = Convert.ToInt32(numberStr);
    numbers.AddNumber(number);
    Console.WriteLine(numbers.GetValues());
}