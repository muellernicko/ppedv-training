#region Variable
//Variable: <Typ> <Name>
using System.Net.WebSockets;

int Zahl;
Zahl = 5;
Console.WriteLine(Zahl); //cw + Tab


/*
 * Mehrzeiliger 
 * Kommentar
 */


// Datentypen
//Ganze Zahlen: byte, short, int, long
long l = 23456789098765432;

//Kommazahlen: float, double, decimal
double d = 4356789.524342314;
float f = 23456.5234436532f;
decimal m = 23456789.2343456m;

//Texttypen: char, string
string s = "Hallo"; //Doppelte Hochkomma
char c = 'A'; //Einzelne Hochkomma

//booleand
bool bt = true;
bool bf = false;
#endregion

#region Strings
//Strings verbinden
string kombi = "Der Text ist "  + s + ", die Zahl ist " + Zahl + ", die Kommazahl ist " + d;
Console.WriteLine(kombi);

//String Interpolation: Ermöglicht, Code in String einzubinden
string interpolation = $"Der Text ist {s}, die Zahl ist {Zahl}, die Kommazahl ist {d}";
Console.WriteLine(interpolation);

//Escape Sequenzen: Untippbare Zeichen in einem String einbauen
string umbruch = "Umbruch \n Umbruch";
Console.WriteLine(umbruch);

string pfad = "C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\7.0.12\\System.Collections.Concurrent.dll";
Console.WriteLine(pfad);

//Verbatim String (@-String): String der Escape-Sequenzen ignoriert
string umbruch2 = @"Umbruch \n Umbruch";
string pfad2 = @"C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.12\System.Collections.Concurrent.dll";
Console.WriteLine(pfad2);
Console.WriteLine(umbruch2);
#endregion

#region Eingabe
string input = Console.ReadLine(); //Wartet, bis der User Enter druck, und  schreibt dannn seine Eingabe in die Input Variable
Console.WriteLine($"Du hast {input} eingegeben");

Console.Write("Gib eine Zahl ein: "); //Write: Macht am Ende der Zeile keinen Umbruch
Console.ReadLine();

ConsoleKeyInfo info = Console.ReadKey(); //Wartet auf genau einen Input (ohne Enter)
Console.WriteLine($"Du hast {info.Key} gedrückt"); //ConsoleKeyInput: Enthält mehrere Informationen zum gedrückten Key
#endregion

#region Konvertierungen
//Drei Richtungen
//beliebiger Typ --> string
//string -> beliebiger Typ
//beliebger Typ -> beliebiger Typ

//ToString()
string ZahlAlsSting = Zahl.ToString();

//Parse(...)
Console.Write("Gib eine Zahl ein: ");
string zahlInput = Console.ReadLine();
int x = int.Parse(zahlInput); //Parse versucht den String zu einer Zahl umzuwandeln
Console.WriteLine($"Deine Zahl mal zwei ist {x * 2}");

//Typecase, Casting, Cast
double y = 34567.234324;
int z = (int) y; //Explizite Konvertierung: Umwandlung von double zu int erzwingen mittels cast
Console.WriteLine(z); //Kommastellen werden abgeschnitten
double a = z; //Implizite Konvertierung: Alle ints passen in double hinein
#endregion

#region Arithmetik
int zahl1 = 7;
int zahl2 = 4;

Console.WriteLine(zahl1 + zahl2); //Berechnet die Summe, aber lässt die Variablen unberührt
Console.WriteLine(zahl1);
Console.WriteLine(zahl2);

zahl1 += zahl2; //Berechnet die Summe und schreibt das Ergebnis in die linke Variable hinein
Console.WriteLine("-------------");
Console.WriteLine(zahl1);
Console.WriteLine(zahl2);

//Modulo: Rest der Division
Console.WriteLine(zahl2 % zahl1); //Sind die zwei Zahlen restlos teilbar?
Console.WriteLine(zahl1 % 2); //Ist die Zahl gerade?

zahl1++; //zahl1 += 1
zahl2--; //zahl 2 -= 1

Math.Floor(4.5); //abrunden
Math.Ceiling(4.5); //aufrunden
Math.Round(4.5); //Rundet auf oder ab, .5 wird zum nächsten gerade Wert gerundet
Math.Round(4.5); //4
Math.Round(5.5); //6

//Auf X Kommastellen runden
double r = Math.Round(34567.234324, 2); //Auf 2 Kommastellen runden
Console.WriteLine(r);

//Divisionen
Console.WriteLine(8 / 5); //1
Console.WriteLine(8 / 5.0); //1.6
Console.WriteLine(8.0 / 5); //1.6
Console.WriteLine(8d / 5); //1.6
Console.WriteLine(8f / 5); //1.6
Console.WriteLine(8m / 5); //1.6
Console.WriteLine((double)zahl1 / zahl2); //Konvertierungen erzwingen, um eine Kommadivision durchzuführen
#endregion
