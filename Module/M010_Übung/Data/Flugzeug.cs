namespace M010_Übung.Data;

public class Flugzeug : Fahrzeug
{
    public int maximaleFlughoehe { get; set; }

    public Flugzeug(string name, int maximaleGeschwindigkeit, int MaximaleFlughoehe) : base(name, maximaleGeschwindigkeit)
    {
        maximaleFlughoehe = MaximaleFlughoehe;
    }

    public override string Info()
    {
        return $"Das Schiff {name}" + base.Info() + $"Es hat eine maximale Flughöge von {maximaleFlughoehe}m.";
    }

    public override void Hupen()
    {
        Console.WriteLine($"{name}: Flugzeug-Huuuuuup!");
    }
}
