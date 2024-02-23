using Newtonsoft.Json;
using System.Text.Json;

namespace M014;

internal class Program
{
    static void Main(string[] args)
    {
        //NuGet-Packages: Externe Pakete, die zum Projekt hinzugefügt werden können
        //Tools --> NuGet Package Manager --> Manage NuGet Packages
        //Paket + Projekt auswählen --> Install

        List<Fahrzeug> fahrzeuge = new List<Fahrzeug>;

        string json = JsonConvert.SerializeObject(fahrzeuge);
        File.WriteAllText("Test.json", json);

        string readJson = File.ReadAllText("Test.json");
        Fahrzeug[] readFzg = JsonConvert.DeserializeObject<Fahrzeug[]>(readJson);

    }

    public static void Intro()
    {
        //Drei wichtige Klassen: File, Directory, Path

        //Pfad zu einem Ordner + Pfad zu einer Datei
        //Den Ordner erstellen, Die Datei beschreiben

        string folderPath = "Test";
        string filePath = Path.Combine(folderPath, "M014.txt"); //Hier werden noch keine Dateien oder Ordner erstellt

        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        //Stream: Pipeline zu einer externen Ressource
        //z.B. Datei, DB, Webschnittstelle, usw...

        StreamWriter sw = new StreamWriter(filePath);
        sw.WriteLine("Test1");
        sw.WriteLine("Test2");
        sw.WriteLine("Test3");
        sw.Flush();
        sw.Close(); //Streams müssen per Hand geschlossen werden

        using (StreamWriter sw2 = new StreamWriter(filePath))
        {
            sw2.WriteLine("Test1");
            sw2.WriteLine("Test2");
            sw2.WriteLine("Test3");
        } //Hier wird automatisch dispose() aufgerufen

        //using-Statement: Schließt den Stream am Ende der Methode automatisch
        using StreamWriter sw3 = new(filePath);
        sw3.WriteLine("Test1");
        sw3.WriteLine("Test2");
        sw3.WriteLine("Test3");


        using StreamReader sr = new(filePath);
        //string alles  = sr.ReadToEnd();

        List<string> lines = new();
        while (!sr.EndOfStream)
        {
            lines.Add(sr.ReadLine());
        }

        //Kurze Lesemethoden:
        File.ReadAllText(filePath);
        File.ReadAllLines(filePath);

        File.WriteAllText(filePath, "Test");
        File.WriteAllLines(filePath, lines);
    }
}