//Ü2.2
int[] zahlen = { 11, 22, 33, 44, 55 };

Console.Write("Gib einen Tipp ab: ");
string tipp = Console.ReadLine();
int x = int.Parse(tipp);

if (x >= 0 && x <= 100)
{
	if (zahlen.Contains(x))
	{
		Console.WriteLine("Glückwunsch!!!");
	}
	else
	{
		Console.WriteLine("Daneben...");
	}
}
else
{
	Console.WriteLine("Zahl muss zwischen 0 und 100 liegen");
}

//Ü2.1
Console.Write("Gib ein Jahr ein: ");
string input = Console.ReadLine();
int jahr = int.Parse(input);

bool schaltjahr = false;
if (jahr % 4 == 0)
	schaltjahr = true;

if (jahr % 100 == 0)
	schaltjahr = false;

if (jahr % 400 == 0)
	schaltjahr = true;

Console.WriteLine($"{jahr} ist {(schaltjahr ? "ein" : "kein")} Schaltjahr.");

//DateTime.IsLeapYear(jahr);