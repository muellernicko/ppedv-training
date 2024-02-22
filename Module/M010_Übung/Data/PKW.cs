namespace M010_Übung.Data;

public class PKW : Fahrzeug
{
    public int sitzAnzahl { get; set; }
    public PKW(string name, int maximaleGeschwindigkeit, int SitzAnzahl) : base(name, maximaleGeschwindigkeit)
    {
        sitzAnzahl = SitzAnzahl;
    }


    public override string Info()
    {
        return $"Der PKW {name}" + base.Info() + $"Er hat {sitzAnzahl} Plätze.";
    }

    public override void Hupen()
    {
        Console.WriteLine($"{name}: PKW-Huuuuuup!");
    }
}
