namespace M006.Data
{

    /// <summary>
    /// Klasse: Bauplan für Objekte, hier wird die Struktur der Objekte festgelegt, über Variablen, Methoden, ...
    /// Objekt: Fertige Datenstruktur die aus einer Klasse erzeugt wird
    /// Objekt enthält konkrete Werte, Klasse enthält nur Definitionen
    /// 
    /// Klassen sind Datentypen
    /// Mithilfe von Klassen können Komplexe Datenstrukturen dargestellt werden
    /// Simple Datentypen: int, double, string, bool, ...
    /// Komplexe Datentypen: Person, Kurs, ...
    /// </summary>

    public class Person
    {
        //Eigenschaften: Vorname, Nachname, Alter, ...
        //Funktion: Sprechen, ...

        #region Variable/Feld
        //felder sind normale Variablen
        //Felder sollten von außen nicht angreifbar sein, sondern nur über Get- und Set Methoden benutzt werden können
        //Warum? Weil der Benutzer bei direktem Zugriff auf das Feld, alles mit dem Feld machen könnte
        //z.B. Zahlen, etc. im Vornamen, ...

        /// <summary>
        /// private: Kann nur innerhalb der Klasse angegriffen werden
        /// </summary>
        private string vorname;

        public void SetVorname(string vorname)
        { 
            if(vorname.All(char.IsLetter) && vorname.Length >=3 && vorname.Length <=15) //Prüfen, ob der Vorname, den der User setzten möchte, valide ist
                this.vorname = vorname; //this: Greife aus der Methode hinaus, Nur Vorname würde bedeuten, dass auf Eingabewert der Funktion zugegriffen wird
            //Hier gibt es den Parameter vorname, und das Feld vorname
            //Mittels this Differenzieren welches der beiden Felder gemeint ist
        }

        public string GetVorname()
        { 
            return this.vorname; //Hier würde mit und ohne this funktionieren, da kein Parameter vorhanden als Übergabewert der Methode
        
        }
        #endregion

        #region Property
        //Property/Eigenschaft: Gibt die Möglichkeit, Get-Set Methoden zu vereinfachen
        private string nachname;

        public string Nachname
        {
            get
            {
                return nachname;
            }
            set
            {
                //Hier gibt es keinen Parameter namens nachname
                //value ist hier das Parameter-Keyword
                //Der Parameter wird im Setter als "value" bezeichnet
                if (value.All(char.IsLetter) && value.Length >= 3 && value.Length <= 15)
                    nachname = value;
            }
        }

        // Drei Arten von Properties
        //Full Property: privates Feld und Getter + Setter mit Code (siehe oben)
        //Auto Property: Funktioniert wie ein normales Feld, aber hat bestimmte Vorteile
        //Get-Only Poperty: Kann man nicht beschrieben werden, berechnet nur Werte

        //Auto-Property
        //Einzelne Accessoren (Get oder Set) können mit einem Access Modifier (private) belegt werden
        //Verwendung: Json, UI
        public int Alter { get; private set; }

        //Get-only Property

        public string VollerName
        {
            get
            {
                return vorname + " " + nachname;
            }
        }

        public string VollerName2
        {
            get => vorname + " " + nachname;
        }

        public string VollerName3 => vorname + " " + nachname;
        #endregion

        #region Konstruktur
        /// <summary>
        /// Konstruktor: Code der bei Erstellung (new) des Objekts ausgeführt wird
        /// Standardkonstruktor existiert immer, es sei denn er wird überschrieben
        /// </summary>
        public Person()
        {
            Console.WriteLine("Person wurde erstellt");
            Zaehler++;
        }
        /// <summary>
        /// Hier wird der Standardkonstruktor gelöscht
        /// Bei Erstellung einer Person muss Vorname und Nachname angegeben werden
        /// </summary>
        public Person(string vorname, string nachname) : this()
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        /// <summary>
        /// Konstruktoren verketten:
        /// Wenn dieser Konstruktor ausgeführt wird, wird der Konstruktur darüber in der Kette auch ausgeführt
        /// Über die PArameter in this(...) wird der Konstruktur ausgewählt, der verkette werden soll
        /// </summary>
        public Person (string vorname, string nachname, int alter) : this(vorname, nachname)    
        {
            //this.vorname = vorname;
            //this.nachname = nachname;  
            this.Alter = alter;
        }

        #endregion
        public static int Zaehler { get;  set; }

    }
}