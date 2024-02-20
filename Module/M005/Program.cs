using System.Reflection.PortableExecutable;

namespace M005
{
    internal class Program
    {

        /// <summary>
        /// Main Methode: Einstiegspunkt des Programms
        /// In jedem Programm muss immer eine Main Methode existieren
        /// Bei der Öffnungsklammer startet das Programm, wenn es ausgeführt wird
        /// </summary>
        static void Main(string[] args)
        {
            PrintAddiere(4, 5);
            PrintAddiere(4, 510);
            PrintAddiere(4, 510);
            PrintAddiere(4, 545);
            PrintAddiere(4, 785);

            int summe = Addiere(4, 8); //Hier das Ergebnis der Funktion in eine Variable speichern
            Console.WriteLine($"Die Summe ist: {summe}");
            }
        /// <summary>
        /// Aufbau einer Funktion:
        /// Rückgabeteyp Name(Par1, Par2, Par3, ...)
        /// {Body}
        /// 
        /// void: Kein Ergebnis
        /// nicht void: Ergebnis
        /// </summary>
        static void PrintAddiere(int x, int y) 
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        /// <summary>
        /// Rückgabetyp int --> Per return muss ein int zurückgegeben werden
        /// </summary>
        /// <returns></returns>

        static int Addiere(int x, int y)
        {
            return x + y;
            Console.WriteLine(); //Unreachable code detected
        }
    }
}