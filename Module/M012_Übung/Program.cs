namespace M012_Übung;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;

internal class Program
{
    static void Main(string[] args)
    {
        #region File lesen
        string readJson = File.ReadAllText(@"..\..\..\Personen.json");
        List<Person> personen = JsonSerializer.Deserialize<List<Person>>(readJson)!;
        #endregion

        //1
        personen.Where(e => e.Alter >= 60);

        //2
        personen.Where(e => e.Job.Gehalt > 5000);

        //3
        personen.OrderBy(e => e.Job.Titel).ThenBy(e => e.Job.Gehalt);

        //4
        personen.Count(e => e.Vorname.Length > 10);

        //5
        personen.Where(e => e.Job.Titel == "Softwareentwickler").Average(e => e.Job.Gehalt);

        //6
        personen.Count(e => e.Hobbies.Count == 2);

        //7
        personen.All(e => e.Alter > 50 && e.Job.Gehalt *12 >25000);

        //8
        personen.Where(e => e.Hobbies.Contains("Radfahren") && e.Hobbies.Contains("Laufen"));

        //9
        personen.Where(e => e.Vorname.StartsWith("M") && e.Nachname.StartsWith("S"));

        //10
        personen.Where(e => e.Vorname.First() == e.Nachname.First());
        personen.Where(e => e.Vorname[0] == e.Nachname[0]); //Alternative

        //11
        personen.Where(e => e.Job.Gehalt > personen.Average(e => e.Job.Gehalt));

        //12
        personen.FindAll(e => e.Alter > 60 && (e.Hobbies.Contains("Laufen") || e.Hobbies.Contains("Radfahren") || e.Hobbies.Contains("Ballsport") || e.Hobbies.Contains("Fitness")));

        //13
        //personen.Distinct();

        //14
        personen.Where(e => e.Job.Titel == "Tischler").Max(e => e.Job.Gehalt);

        //15
        personen.Where(e => e.Geburtsdatum.ToString().Contains("1977"));

        //16
        //???

        //17
        personen.OrderByDescending(e => e.Job.Gehalt).Take(5);

        //18
        personen.Where(e => (DateTime.Today.Year - e.Job.Einstellungsdatum.Year) > 20);

        //19

        //20

        //21

        //22
        personen.GroupBy(e => e.Job.Titel).ToDictionary(e => e.Key, e => e.OrderByDescending( x => x.Job.Gehalt).Take(3).ToList());


    }
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
    "Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////