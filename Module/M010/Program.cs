using System.Text;

namespace M010;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; //€-Zeichen in der Konsole aktivieren
        Smartphone s = new Smartphone();
        s.Aufladen(50);
        Console.WriteLine(s.Ladezustand());

        Wertkarte w = new Wertkarte();
        w.Aufladen(5);
        Console.WriteLine(w.Ladezustand());

        IAufladbar[] ladbar = new IAufladbar[2];
        ladbar[0] = s;
        ladbar[1] = w;

        foreach (IAufladbar l in ladbar)
        {
            l.Aufladen(10);
            Console.WriteLine(l.Ladezustand());


            if (l is IAufladbar)
            {
                Console.WriteLine("Das ist ein aufladbares Objekt");
            }
        }

        #region Beispiele von C#
        //IEnumerable: Basis von allen Listentypen in C#
        //z.B. Array, List, Dictionary, Stack, Queue, DataSet, ...
        //Sorgt dafür, dass ein bestimmter Typ mit einer Schleife angegriffen werden kann


        IEnumerable<int> x = new int[10];
        IEnumerable<int> y = new List<int>();
        IEnumerable<int> z = new Stack<int>();

        foreach (int i in x) { }
        foreach (int i in y) { }
        foreach (int i in z) { }

        PrintList(x);
        PrintList(y);
        PrintList(z);

        #endregion
    }

        public static void PrintList(IEnumerable<int> x) { }

}

/// <summary>
/// Interface: Stellt eine Struktur dar, wie eine Abstrakteklasse, kann aber mehrmals vererbt werden
/// Hintergrund: Verschiedene Typen, die nichts miteinander zu tun haben, zusammen gruppieren zu können
/// Interface erzwingt aber weiterhin die Implementation von Methoden und Properties
/// </summary>
public interface IAufladbar
{
    public int Ladung {  get; set; }

    public void Aufladen(int n);

    public string Ladezustand();
}

/// <summary>
/// Smartphone und Wertkarte sind beide aufladbar, haben aber sonst keine Gemeinsamkeiten
/// Smartphone ist ein Elektrogerät, Wertkarte hält ein Guthaben
/// </summary>
public class Smartphone : IAufladbar
{
    public int Ladung { get; set; } // => throw new NotImplementedException() einfach löschen

    public void Aufladen(int n)
    {
        if (n > 0 && n <= 100)
            Ladung += n;

        if (Ladung > 100)
            Ladung = 100;
    }

    public string Ladezustand()
    {
        return $"Die Ladung des Smartphones beträgt {Ladung}%.";
    }
}

public class Wertkarte : IAufladbar
{
    public int Ladung { get ; set ; }

    public void Aufladen(int n)
    {
        if (n>0)
            Ladung += n;
    }

    public string Ladezustand()
    {
        return $"Ladung: {Ladung} €";
    }
}