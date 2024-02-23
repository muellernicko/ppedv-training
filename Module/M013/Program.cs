using System;
using System.Data.SqlClient;

namespace M013;

internal class Program
{
    static void Main(string[] args)
    {

        try //Codeblock markieren -> Rechtsklick -> Snippet -> Surround with -> try(f)
        {
            Console.Write("Gib eine Zahl an: ");
            string eingabe = Console.ReadLine(); //Maus über Methode --> Exceptions sind die Fehler die auftreten könnten
            int x = int.Parse(eingabe); //3 Exceptions: ArgumentNullException, FormatException, OverflowException
        }
        catch (FormatException) //Hier wird nur die die FormatException behandelt (keine Zahl eingegeben)
        {
            Console.WriteLine("Keine Zahl eingegeben");
        }
        catch (OverflowException)//Hier wird nur die die OverflowException behandelt
        {
            Console.WriteLine("Zahl zu klein/groß");
        }
        catch (Exception e) //Exception sind in einer Vererbungshierachie zueinander, Exception ist die Oberklasse aller Exceptions
        {
            //Dieser Block fängt alle anderen Fehler
            Console.WriteLine("Anderer Fehler"); ;
            Console.WriteLine(e.Message); //Die C# interne Nachricht
            Console.WriteLine(e.StackTrace); //Ein Logoutput der uns Bescheid gibt, wo der Fehler im Code aufgetreten ist
        }
        finally //Wird immer ausgeführt und ist optional
        {
            Console.WriteLine("Parsen fertig");
        }

        try
        {
            Fahrzeug f = new Fahrzeug();
            f.Beschleunige(500); //Exception
        }
        catch (ArgumentException e)
        {

            Console.WriteLine(e.Message);
        }

    }

    public static void ConnectToDb()
    {
        Console.WriteLine("Verbindung wird initiier");
        if(Random.Shared.Next() % 2 == 0)
        {
            throw new Exception("Verbindung konnte nicht hergestellt werden");
        }
    }

    public static void ConnectToSQL()
    {
        try
        {
            SqlConnection conn = new SqlConnection("Server=WIN10-LK3;Database=Demo;Trusted_Connection=True");
            conn.Open();
        }
        catch (SqlException)
        {

            Console.WriteLine("Verbindung fehlgeschlagen");
            //Logger.log("Verbindung fehlgeschlagen");
            //GUI: TextBlock.Text="Verbindung fehlgeschlagen";
        }
    }
    public class Fahrzeug
    {
        public void Beschleunige(int a)
        {
            if (a > 300)
            {
                //Console.WriteLine("Neue Beschleunigung ist nicht valide.");
                throw new ArgumentException("Neue Beschleunigung ist nicht valide.");
            }

        }
    }

}