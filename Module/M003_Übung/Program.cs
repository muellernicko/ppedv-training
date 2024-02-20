//1
Console.Write("Gib ein Jahr an: ");
int jahr = int.Parse(Console.ReadLine());
bool schaltjahr = false;

if (jahr % 4 == 0)
{
    schaltjahr = true;

    if (jahr % 100 == 00)
    {
        schaltjahr = false;

        if (jahr % 400 == 0)
        {
            schaltjahr = true;
        }
    }
}
else
{
    schaltjahr = false;
}

Console.WriteLine($"{jahr} ist Schaltjahr: {schaltjahr}");

//2
int[] gewinnzahlen = new int[] { 1, 17, 35, 40, 60};

Console.Write("Gib deinen Tipp ab: ");
int eingabe = int.Parse(Console.ReadLine());

if (gewinnzahlen.Contains(eingabe) && eingabe < 100 && eingabe > 0)
{
    Console.WriteLine("Glückwunsch!! Du hast eine der fünf Gewinnzahlen getippt.");
}
else if (eingabe < 100  || eingabe > 0)
{
    Console.WriteLine("Leider liegt die Zahl außerhalb der zulässigen Bereichs.");
}
else
{
    Console.WriteLine("Leider kein Glück gehabt.");
}