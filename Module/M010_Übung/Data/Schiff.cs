namespace M010_Übung.Data;

public class Schiff : Fahrzeug, IBeladbar
{
    public int tiefgang { get; set; }

    public Schiff(string name, int maximaleGeschwindigkeit, int Tiefgang) : base(name, maximaleGeschwindigkeit)
    {
        tiefgang = Tiefgang;
    }

    public override string Info()
    {
        return $"Das Schiff {name}" + base.Info() + $"Es hat {tiefgang}m Tiefgang und ist mit {GeladenesFahrzeug} beladen.";
    }

    public override void Hupen()
    {
        Console.WriteLine($"{name}: Schiff-Huuuuuup!");
    }

    public Fahrzeug GeladenesFahrzeug { get; set; }

    public void Belade(Fahrzeug fahrzeug)
    {
        if (GeladenesFahrzeug == null)
        {
            GeladenesFahrzeug = fahrzeug;
        }
        else
        {
            Console.WriteLine("Schiff ist schon beladen.");
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
