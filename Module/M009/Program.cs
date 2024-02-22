namespace M009;

internal class Program
{
    static void Main(string[] args)
    {
        #region Polymorphismus
        //Polymorphismus
        //Typkompatiblität
        //Welche Typen sind mit welchen Typen kompatibel?

        //Ein Objekt iost immer mit sich selbst oder einer Oberklasse kompatibel
        Mensch m = new Mensch();

        Lebewesen l = new Mensch();
        l = new Hund();


        //Jeder Typ in C# ist ein Objekt
        // --> Jedes Objekt ist mit einer Variable vom Typ object kompatibel
        object o = new object();
        o = new Mensch();
        o = new Lebewesen();
        o = 123;
        o = true;
        o = "Hallo";

        Test(new Mensch());
        Test(123);
        Test("Hallo");

        PrintLebewesen(new Lebewesen());
        PrintLebewesen(new Hund());

        #endregion

        #region Typen
        //Typ
        //Jede Klasse/Struct/Enum/Interface/... stellt einen Typen dar
        //z.B. Lebewesen ist ein Typ, object ist ein Typ, Wochentag (enum) ist auch ein Typ

        //2 Möglichkeiten um an ein Typ Object zu kommen
        //Typ über Objekt holen
        Type mt = m.GetType();

        //Typ über Klassennamen holen
        Type tt = typeof(Mensch);

        Console.WriteLine(mt.Name); //Mensch
        #endregion

        #region Typvergleiche
        object x = new Mensch();
        //Wie kann ich zur Laufzeit herausfinden, was für ein Objekt hinter x steckt?

        //Genauer Typvergleich

        if (x.GetType() == typeof(Mensch))
        {
            //false
        }

        if(x.GetType() == typeof(Lebewesen))
        {
            //true
        }
        #endregion

        #region Beispiel
        Lebewesen[] zoo = new Lebewesen[5]; //Dieses Array kann alle Lebewesen enthalten
        zoo[0] = new Mensch();
        // zoo[1] = new Lebewesen(); //Nicht mehr möglich da abstract class
        zoo[2] = new Katze();
        zoo[3] = new Hund();
        zoo[4] = new Hund();

        foreach(Lebewesen lw in zoo)
        {
            if (lw is Mensch) //Per Typvergleich prüfen, ob das derzeitige Objekt ein MEnsch ist
            {
                Mensch mensch = (Mensch)lw;
                //Nachdem wir hier im Code sind, hat der Typvergleich  in der if true ergeben
                //Dementsprechend ist lw ein Mensch
                //Per Cast können wir jetzt das Lebewesen ansprechen und auf die Menschspezifischen Eigenschaften zugreifen
                Console.WriteLine(mensch.Adresse);
                mensch.Sprechen();
            }

            if (lw is Katze)
            {
                Katze k = (Katze)lw;
                k.Miau();
            }

            lw.WasBinich(); //Durch Abstract wissen wir, dass jede Unterklasse diese Methode hat
        }
        #endregion

    }

    /// <summary>
    /// Diese Methode kann über den object Parameter alles empfangen
    /// </summary>
    public static void Test(object o)
    {
    }

    /// <summary>
    /// Diese MEthode kann beliebige Objekte zurückgeben
    /// </summary>
    public static object Test()
    {
        return new Mensch();
        return 123;
        return "Hallo";
    }

    public static void PrintLebewesen(Lebewesen l)
    {
        
    }
}
´/// <summary>
/// abstract: Definiert, dass diese Klasse nur eine Strukturklasse darstellt
/// //Die Klasse definiert nur Member (Methoden, Properties, Konstruktoren, usw...) und zwingt die Unterklassen eine Implementation zu machen
/// Von dieser Klasse können jetzt keine Objekte mehr erstellt werden (nur noch von den Unterklassen)
/// </summary>
public abstract class Lebewesen
{
    /// <summary>
    /// Diese Methode hat keinen Body --> Unterklassen müssen eine Implementierung derer haben
    /// </summary>
    public abstract void WasBinich();
}

public class Mensch : Lebewesen 
{
    public string Adresse { get; set; } 

    public void Sprechen() { }

    public override void WasBinich()
    {
        Console.WriteLine("Ich bin ein Mensch");
    }
}

public class Hund : Lebewesen
{
    public override void WasBinich()
    {
        Console.WriteLine("Ich bin ein Hund");
    }
}

public class Katze : Lebewesen
{
    public void Miau() { }

    public override void WasBinich()
    {
        Console.WriteLine("Ich bin eine Katze");
    }
}