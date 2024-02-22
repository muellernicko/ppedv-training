using System.Text;

namespace M008_Übung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Fahrzeug f = new Fahrzeug("test", 300);
            PKW p1 = new PKW("Mercedes", 300, 9);
            Schiff s1 = new Schiff("Queen 2", 20, 20);
            Flugzeug f1 = new Flugzeug("Boeing 747", 900, 9000);

            Console.WriteLine(p1.Info());
            Console.WriteLine(s1.Info());
            Console.WriteLine(f1.Info());
        }
    }
}