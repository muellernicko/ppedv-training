using M006_Übung.Data;

namespace M006_Übung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Fahrzeug f1 = new Fahrzeug("Porsche", 300);
            Console.WriteLine(f1.Info());
            f1.StarteMotor();
            f1.Beschleunige(200);
            Console.WriteLine(f1.Info());
            f1.Beschleunige(-40);
            Console.WriteLine(f1.Info());
            f1.Beschleunige(-160);
            Console.WriteLine(f1.Info());
            f1.StoppeMotor();
        }
    }
}