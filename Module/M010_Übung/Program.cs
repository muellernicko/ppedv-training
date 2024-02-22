using M010_Übung.Data;
using System.Threading.Tasks.Dataflow;

namespace M010_Übung;

internal class Program
{
    static void Main(string[] args)
    {

    }

    void TesteBeladen(object Fahrzeug1, object Fahrzeug2)
    {
        if (Fahrzeug1 is IBeladbar && Fahrzeug2 is Fahrzeug)
        {
            IBeladbar beladbar = (IBeladbar) Fahrzeug1;
            Fahrzeug fzg = (Fahrzeug)Fahrzeug2;
            beladbar.Belade(fzg);
        }
        else if (Fahrzeug2 is IBeladbar && Fahrzeug1 is Fahrzeug)
        {
            IBeladbar beladbar = (IBeladbar)Fahrzeug2;
            Fahrzeug fzg = (Fahrzeug)Fahrzeug1;
            beladbar.Belade(fzg);
        }
        else
        {
            Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }

    }
}

