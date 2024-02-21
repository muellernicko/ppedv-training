using M006.Data;
namespace M006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new Person(): Erstelle ein Objekt aus der Klasse
            //Hier können jetzt konkrete Werte eingefüllt werden
            Person p = new Person();
            //p.Vorname = "Max"; //Nicht möglich, da privat
            p.SetVorname("Max"); //Zugriff auf das Feld gewähren, aber nur eingeschränkt
            Console.WriteLine(p.GetVorname());

            p.Nachname = "Mustermann"; //Hier ist kein SetNachname erforderlich
            Console.WriteLine(p.Nachname); //Nachname kann wie eine Variable benutzt werden

            Console.WriteLine(p.VollerName);

            Person p2 = new Person("Max", "Mustermann"); //Durch den Konstruktor müssen die Werte übergeben werden
            Console.WriteLine(p2.VollerName);

            Person p3 = new Person("Max", "Mustermann", 48);
            Console.WriteLine(p3.VollerName);

            //Namespaces
            //Organisationseinheiten, ermöglichen das Gruppieren von Typen in Paketen
            //Jedes Projekt sollte einen Standardnamespace haben z.B. M006
            //Jeder Namespace kann nochmal unterteilt werden in weitere Namespaces z.B. M006.Data
            //Nachdem Person jetzt in M006.Data ist, ist sie hier nichtmehr sichtbar --> using
            //using: Importiert alle Typen aus dem gegebenen Namespace
            //Jeder Typ sollte immer in dem Ordner sein der mit seinem Namespace zusammenhängt

            //Beispiele:
            //System: Standarddinge
            //System.IO: Dateiverarbeitung
            //System.Net: Netzwerkbasierte Dinge
            //System.Net.Http: Http-basierte Dinge



            //Assoziation von Objekten
            //Verschachteln von Objekten in anderen Objekten
            //z.B. Person enthät string
            //string enthält Zeichen (chars)
            //chars sind Zahlen

            Person t = new Person("Lukas", "Kern", 25);
            Person t1 = new Person("", "", 48);
            Person t2 = new Person("", "", 42);
            Person t3 = new Person("Nicko", "Müller", 26);
            Kurs k = new Kurs("C# Grundkurs", 4, Kurstyp.Virtuell, t, t1, t2, t3) ;
            k.PersonenAusgeben();

        }
    }
}