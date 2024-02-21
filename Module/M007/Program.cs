using System.Security.Cryptography;

namespace M007;

class Program
{
    static void Main(string[] args)
    {
        //Enumerable.Range(0, 1_000_000_000).ToList(); //Wird automatisch am Ende des Programms eingesammelt.

        #region Static / Statische Member
        //Static: global, statische Member können von überall angegriffen werden
        Console.WriteLine(); //Statischer Zugriff über Console.
        //Console c = new Console(); //Konsole kann nicht erstellt werden, weil static

        //Person.Alter = 1; //Hier wird ein Objekt benötigt, weil Alter individuell ist
        // Person P = new Person();
        //P.Alter = 10;

        Console.WriteLine(DateTime.Now);
        #endregion

        #region Werte- / und Referenztypen
        //struct cs class

        //Zuweisung
        //class: referenziert
        //struct: kopiert

        //Vergleich
        //class: Speicheradressen
        //struct: Inhalte
        #endregion

        #region Null
        //Null: kein Wert
        Person p2 = null; //Variable ist hier null
        //Console.WriteLine(p2.Alter); //p2 enthält kein Objekt

        if(p2 != null){ //wenn in p2 etwas enthalten ist
            Console.WriteLine(p2.Alter);
        }

        //nicht nullable: int, double, char, float, bool, ... (structs)
        //int x = null; //Nicht möglich
        int? x = null; //? am Ende eines Typens macht diesen typen nullable
        #endregion

        #region Datumswerte
        //DateTime und TimeSpan

        //DateTime: fixer Zeitpunkt mit Jahr, Monat, Tag, Stunde, Minute, Sekunde, ...
        Console.WriteLine(DateTime.Now);

        Console.WriteLine(new DateTime(2000, 1 , 1));

        Console.WriteLine(DateTime.Now - new DateTime(2000, 1, 1));

        Console.WriteLine(DateTime.Now + TimeSpan.FromDays(3));
        
        Console.WriteLine(DateTime.Now + TimeSpan.FromHours(60)); //Datumswerte addieren

        //DateTimeOffset.Now(); //Für Handling mit Zeitzonen
        #endregion
    }
    /// <summary>
    /// Coder der beim Aufräumen durch den GarbageCollector (GC) ausgeführt wird
    /// </summary>
    ~Program()
    {
        Console.WriteLine("Programm Ende");
    }
}


