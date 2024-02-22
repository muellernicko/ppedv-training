namespace M010_Übung.Data;

internal class Container : IBeladbar
{
    public Fahrzeug GeladenesFahrzeug { get; set; }

    public void Belade(Fahrzeug fahrzeug)
    {
        if (GeladenesFahrzeug == null)
        {
            GeladenesFahrzeug = fahrzeug;
        }
        else
        {
            Console.WriteLine("Container ist schon beladen.");
        }
    }

    public Fahrzeug Entlade()
    {
        if (GeladenesFahrzeug != null)
        {
            GeladenesFahrzeug = null;
            return GeladenesFahrzeug;
        }
        else
        {
            Console.WriteLine("Es ist kein Fahrzeug geladen");
            return null;
        }

    }
}
