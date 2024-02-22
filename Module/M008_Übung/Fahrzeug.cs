using System.Security.Cryptography;

namespace M008_Übung;
public class Fahrzeug
{
    protected string name { get; set; }

    protected int maximaleGeschwindigkeit { get; set; }

    protected int aktuelleGeschwindigkeit { get; set; }

    protected double preis { get; set; }

    protected bool motorLaueft { get; set; }

    public Fahrzeug(string name, int maximaleGeschwindigkeit)
    {
        this.name = name;
        this.maximaleGeschwindigkeit = maximaleGeschwindigkeit;
        aktuelleGeschwindigkeit = 0;
        this.preis = RandomNumberGenerator.GetInt32(500000);
        motorLaueft = false;
    }

    public virtual string Info()
    {
        return $"kostet {preis} € und fährt momentan {aktuelleGeschwindigkeit} von {maximaleGeschwindigkeit} und der Motor läuft ist {motorLaueft}. ";
    }

    public void StarteMotor()
    {
        if (motorLaueft != true)
        {
            motorLaueft = true;
            Console.WriteLine("Motor wurde gestartet");
        }
        else
        {
            Console.WriteLine("Motor läuft bereits");
        }
    }

    public void StoppeMotor()
    {
        if (motorLaueft == true && aktuelleGeschwindigkeit == 0)
        {
            motorLaueft = false;
            Console.WriteLine("Motor wurde gestoppt");
        }
        else if (motorLaueft == false)
        {
            Console.WriteLine("Motor ist bereits aus");
        }
        else
        {
            Console.WriteLine("Das Fahrzeug steht nicht.");
        }
    }

    public void Beschleunige(int a)
    {
        if (aktuelleGeschwindigkeit + a <= maximaleGeschwindigkeit && aktuelleGeschwindigkeit + a >= 0 && motorLaueft == true)
        {
            aktuelleGeschwindigkeit += a;
            Console.WriteLine($"Geschwindigkeit des Auto hat sich um {a} verändert");
        }
        else
        {
            Console.WriteLine("Unzulässige Geschwindigkeit als Endresultat oder Motor ist aus");
        }
    }
}

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

}

public class Schiff : Fahrzeug
{
    public int tiefgang { get; set; }
    public Schiff(string name, int maximaleGeschwindigkeit, int Tiefgang) : base(name, maximaleGeschwindigkeit)
    {
        tiefgang = Tiefgang;
    }

    public override string Info()
    {
        return $"Das Schiff {name}" + base.Info() + $"Es hat {tiefgang}m Tiefgang.";
    }
}

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

}
