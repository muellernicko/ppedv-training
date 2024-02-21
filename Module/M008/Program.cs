namespace M008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensch m = new Mensch();
            m.Alter = 20; //Alter wurde vererbt
            m.wasBinich();
            Console.WriteLine(m.ToString());
        }
    }
}

/// <summary>
/// Vererbung ermöglicht die Spezifizierung von Klassen
/// Beispiel: Oberbegriff Lebewesen, spezifiziert Mensch, Hund, Katze, ...
/// </summary>
public class Lebewesen
{
    public int Alter {  get; set; }

    public void Bewegen(int distanz)
    {
        Console.WriteLine($"Das Lebewesen bewegt sich um {distanz}m.");
    }

    /// <summary>
    /// Wenn in einer Oberklasse ein Konstruktor definiert wird, muss in den Unterklassen eine Verkettung derer stattfinden
    /// </summary>
    /// <param name="alter"></param>
    public Lebewesen(int alter)
    {
        Alter = alter;
    }

    /// <summary>
    /// virtual: ermöglicht in den Unterklassen eine Überschreibung durchzuführen, um den Code aus der Oberklasse zu verändern
    /// </summary>
    public virtual void wasBinich()
    {
        Console.WriteLine("Ich bin ein Lebewesen");
    }

    /// <summary>
    /// ToString(): Gibt eine String-Repräsentation des Objekts zurück
    /// </summary>
    public override string ToString()
    {
        return "ein Lebewesen";
    }

}

public class Mensch : Lebewesen //Vererbung festlegen
{
    //Alter und Bewegen wird von Lebewesen übernommen

    public string Name {  get; set; }   

    /// <summary>
    /// Strg + . --> Generate Constructor
    /// Hier einfach neue Attribute hinzufügen per normale Eingabe
    /// base: Greife aus dieser Klasse hinaus auf die Attribute der Oberklasse
    /// </summary>
    /// <param name="alter"></param>
    public Mensch(int alter, string name) : base(alter)
    {
        Name = name;    
    }

    public Mensch() : base (0) { }

    /// <summary>
    /// override eintipppen + LEER  --> Methode auswählen
    /// </summary>
    public override void wasBinich()
    {
        //base.wasBinich(); //base führt die Methode aus der Oberklasse aus, falls nur Erweiterung aus der Oberklasse gewünscht
        Console.WriteLine("Ich bin ein Mensch");
         
    }


}

public class Hund : Lebewesen
{
    public Hund(int alter) : base(alter)
    {

    }
}