Console.Write("Gib die Entfernung in m ein: ");
int entfernung = int.Parse(Console.ReadLine());

Console.Write("Gib die Stunden an: ");
int stunden = int.Parse(Console.ReadLine());

Console.Write("Gib die Minuten an: ");
int minuten = int.Parse(Console.ReadLine());

Console.Write("Gib die Sekunden an: ");
int sekunden = int.Parse(Console.ReadLine());

int gesamtzeitS = stunden * 3600 + minuten * 60 + sekunden;

double MeterProSekunde = Math.Round((double)entfernung / gesamtzeitS, 2);
//double KilometerProStunde = Math.Round(((double)entfernung / 1000) / (gesamtzeitS / 3600), 2);
double KilometerProStunde = Math.Round(((double)entfernung / gesamtzeitS) * 3.6,2);
double MeilenProStunde = Math.Round((((double)entfernung / gesamtzeitS) * 3.6)/1.609, 2);
//double MeilenProStunde = Math.Round((((double)entfernung / gesamtzeitS) * 3.6)*0.62137119, 2);

Console.WriteLine($"Meter/Sekunde: {MeterProSekunde}");
Console.WriteLine($"Kilometer/Stunde: {KilometerProStunde}");
Console.WriteLine($"Meilen/Stunde: {MeilenProStunde}");