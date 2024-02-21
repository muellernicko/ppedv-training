while (true)
{

    double zahl1 = ZahlEingabe("Gib eine Zahl an: ");

    double zahl2 = ZahlEingabe("Gib eine weitere Zahl an: ");

    Rechenoperation rechenart = RechenoperationEingabe();

    Rechenoperation art = (Rechenoperation)rechenart;

    Berechne(zahl1, zahl2, art);

    Console.WriteLine("Enter drücken zum Wiederholen");
    if (Console.ReadKey().Key != ConsoleKey.Enter)
        break;
    Console.Clear();
}

double Berechne(double zahl1, double zahl2, Rechenoperation operation)
{
    switch (operation)
    {
        case (Rechenoperation)(int)Rechenoperation.Addition:
            Console.WriteLine($"{zahl1} + {zahl2} = {zahl1 + zahl2}");
            return zahl1 + zahl2;
        case (Rechenoperation)(int)Rechenoperation.Subtraktion:
            Console.WriteLine($"{zahl1} - {zahl2} = {zahl1 - zahl2}");
            return zahl1 - zahl2;
        case (Rechenoperation)(int)Rechenoperation.Multiplikation:
            Console.WriteLine($"{zahl1} * {zahl2} = {zahl1 * zahl2}");
            return zahl1 * zahl2;
        case (Rechenoperation)(int)Rechenoperation.Division:
            if (zahl2 != 0)
            {
                Console.WriteLine($"{zahl1} / {zahl2} = {zahl1 / zahl2}");
                return zahl1 / zahl2;
            }
            else{
                Console.WriteLine(double.NaN);
                return double.NaN;
            }
        default:
            Console.WriteLine("Ungültige Rechenart");
            return -1;
                       
    }
}

double ZahlEingabe(string text)
{
    Console.Write($"{text}");

    while (true)
    {
        string eingabe = Console.ReadLine();
        int ergebnis;
        bool funktioniert = int.TryParse(eingabe, out ergebnis);

        if (funktioniert)
            return ergebnis;
        else
            Console.WriteLine("Valide Zahl eingeben");
    }
}

Rechenoperation RechenoperationEingabe()
{

    foreach (Rechenoperation operation in Enum.GetValues<Rechenoperation>())
    {
        Console.WriteLine($"{(int)operation}: {operation}");
    }
    while (true)
    {
        int rechenart = (int)ZahlEingabe("\nWähle eine Rechenoperation aus: ");

        //TODO: Bei Eingabe falscher Rechenoperation hängt er im Loop fest ...

        if (Enum.IsDefined((Rechenoperation)rechenart))
            return (Rechenoperation)rechenart;
    }
}

enum Rechenoperation { Addition = 1, Subtraktion = 2, Multiplikation = 3, Division = 4 }