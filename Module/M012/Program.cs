using System.Diagnostics;

namespace M012;

internal class Program
{
    static void Main(string[] args)
    {
        #region Einfaches Linq
        List<int> zahlen = Enumerable.Range(1, 20).ToList();

        Console.WriteLine(zahlen.Average());
        Console.WriteLine(zahlen.Min());
        Console.WriteLine(zahlen.Max());
        Console.WriteLine(zahlen.Sum());

        zahlen.First(); //Gibt das erte Element zurück, Exception (Absturz) wenn kein Element gefunden wurde
        zahlen.FirstOrDefault();  //Gibt das erste Element zurück, null/0 wenn kein Element gefunden wurde

        zahlen.Last(); //Gibt das letzte Element zurück, Exception wenn kein Element gefunden wurde
        zahlen.LastOrDefault(); //Gibt das letzte Element zurück, null/0 wenn kein Element gefunden wurde

        //zahlen.First(e => e % 50 == 0); //Finde das erste Element, welches durch 50 restlos teilbar ist (Absturz)
        zahlen.FirstOrDefault(e => e % 50 == 0); //Finde das erste Element, welches durch 50 restlos teilbar ist (0)

        #endregion

        List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
        {
        new Fahrzeug(251, FahrzeugMarke.BMW),
        new Fahrzeug(274, FahrzeugMarke.BMW),
        new Fahrzeug(208, FahrzeugMarke.Audi),
        new Fahrzeug(189, FahrzeugMarke.Audi),
        new Fahrzeug(133, FahrzeugMarke.VW),
        new Fahrzeug(253, FahrzeugMarke.BMW),
        new Fahrzeug(304, FahrzeugMarke.VW),
        new Fahrzeug(180, FahrzeugMarke.Audi),
        new Fahrzeug(190, FahrzeugMarke.Audi)
        };

        #region Linq mit Objekten
        //Alle Fahrzeuge finden die mindestens 200 km/h fahren können
        fahrzeuge.Where(e => e.MaxGeschwindigkeit > 200);

        //Where:
        //Macht eine Schleife auf die Liste, und prüft bei jedem Element, ob die Bedingung in der Lambda Expression true ist
        //e: Das derzeitige Element der Schleife

        List<Fahrzeug> where = new();
        foreach(Fahrzeug e in fahrzeuge) //Die where Funktion als Schleife
        {
            if (e.MaxGeschwindigkeit > 200)
                where.Add(e);
        }

        //Alle VWs mit mindestens 200 km/h
        fahrzeuge.Where(e => e.MaxGeschwindigkeit > 200 && e.Marke == FahrzeugMarke.VW);

        //Sortiere die Liste nach Automarke
        fahrzeuge.OrderBy(e => e.Marke); //Aufsteigend sortieren
        fahrzeuge.OrderByDescending(e => e.Marke); //Absteigend sortieren

        //sortiere nach Marke und danach Geschwindigkeit
        fahrzeuge.OrderBy(e => e.Marke).ThenBy(e => e.MaxGeschwindigkeit);
        fahrzeuge.OrderBy(e => e.Marke).ThenByDescending(e => e.MaxGeschwindigkeit);

        //fahrzeuge.OrderBy(e => e.Marke).ThenBy(e => e.MaxGeschwindigkeit).ThenBy().ThenBy(); //so viele Sortierungen wie benötigt

        //WICHTIG: Bei allen Linq Funktionen, wird niemals die originale Liste verändert

        //Können alle Fahrzeuge mindestens 200km/h fahren?
        fahrzeuge.All(e => e.MaxGeschwindigkeit > 200); //true oder false
        if(fahrzeuge.All(e => e.MaxGeschwindigkeit > 200))
        {
            Console.WriteLine("Alle Fahrzeuge fahren +200 km/h");
        }

        //Können min. ein Fahrzeug mindestens 200km/h fahren?
        fahrzeuge.Any(e => e.MaxGeschwindigkeit > 200); //true oder false
        if (fahrzeuge.All(e => e.MaxGeschwindigkeit > 200))
        {
            Console.WriteLine("Mindestens ein Fahrzeug fährt +200 km/h");
        }

        //Wie viele BMWs haben wir?
        fahrzeuge.Count(e => e.Marke == FahrzeugMarke.BMW); //==> Zahl als Ergebnis

        //Min/MinBy
        fahrzeuge.Min(e => e.MaxGeschwindigkeit); //Die kleinste Geschwindigkeit (int)
        fahrzeuge.MinBy(e => e.MaxGeschwindigkeit); //Das Objekt mit der kleinsten Geschwindigkeit (Fahrzeug)

        //Die 3 schnellsten Fahrzeuge finden
        fahrzeuge.OrderByDescending(e => e.MaxGeschwindigkeit).Take(3);
        
        //Webshop
        int seite = 0;
        fahrzeuge.Skip(seite*5).Take(5);
        // User klickt auf nächste Seite -> SKip(1*5).Take(5)

        //Select
        //Transformiert eine Liste
        //Hauptanwendungsfall: Einzelnes Feld aus der Liste entnehmen

        //Liste mit allen Geschwindigkeiten
        fahrzeuge.Select(e => e.MaxGeschwindigkeit); //int Liste

        //Was ist die Durchscnittsgeschwindigkeit von alles Autos?
        fahrzeuge.Select(e => e.MaxGeschwindigkeit).Average();
        fahrzeuge.Average(e => e.MaxGeschwindigkeit); //Average und Sum haben jeweils eine Funktion, die Select bereits inkludiert
        #endregion

        #region Erweiterungsmethoden

        int zahl = 45678;
        Console.WriteLine(zahl.Quersumme());
        Console.WriteLine(53644.Quersumme());

        fahrzeuge.Shuffle();


        #endregion


    }
}

[DebuggerDisplay("Marke: {Marke}, MaxV: {MaxGeschwindigkeit")] //Anpassen Locals Debugger Darstellung
public class Fahrzeug
{
    public int MaxGeschwindigkeit;

    public FahrzeugMarke Marke;

    public Fahrzeug(int v, FahrzeugMarke fm)
    {
        MaxGeschwindigkeit = v;
        Marke = fm;
    }


}

public enum FahrzeugMarke
{
    Audi, BMW, VW
}