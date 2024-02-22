namespace M010_Übung.Data;

internal interface IBeladbar
{
    public Fahrzeug GeladenesFahrzeug { get; set; }

    public void Belade(Fahrzeug fahrzeug);

    public Fahrzeug Entlade();

}