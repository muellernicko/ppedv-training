//1
int meter;
int stunde;
int minute;
int sekunde;

//2
Console.Write("Entfernung (Meter): ");
string meterInput = Console.ReadLine();
meter = int.Parse(meterInput);

Console.Write("Stunden: ");
string stundeInput = Console.ReadLine();
stunde = int.Parse(stundeInput);

Console.Write("Minuten: ");
string minuteInput = Console.ReadLine();
minute = int.Parse(minuteInput);

Console.Write("Sekunden: ");
string sekundeInput = Console.ReadLine();
sekunde = int.Parse(sekundeInput);

//3
double gesamtSekunden = sekunde + (minute * 60) + (stunde * 3600);

//4
Console.Write("Meter/Sekunde: ");
Console.WriteLine(Math.Round(meter / gesamtSekunden, 2));

Console.Write("Kilometer/Stunde: ");
double km = meter / 1000.0;
double gesamtStunden = gesamtSekunden / 3600;
Console.WriteLine(Math.Round(km / gesamtStunden, 2));

Console.Write("Meilen/Sekunde: ");
double meilen = km * 0.62137119;
Console.WriteLine(Math.Round(meilen / gesamtStunden, 2));