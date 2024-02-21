using System.Security.Cryptography;

namespace M006_Übung.Data
{
    public class Fahrzeug
    {
        private string name { get;  set; }

        private int maximaleGeschwindigkeit { get;  set; }

        private int aktuelleGeschwindigkeit { get; set; }

        private double preis { get; set; }

        private bool motorLaueft { get; set; }

        public Fahrzeug(string name, int maximaleGeschwindigkeit)
        {
            this.name = name;
            this.maximaleGeschwindigkeit = maximaleGeschwindigkeit;
            aktuelleGeschwindigkeit = 0;
            this.preis = RandomNumberGenerator.GetInt32(500000);
            motorLaueft = false;
        }

        public string Info()
        {
            return $"Das Auto {name} kostet {preis}€ und fährt momentan {aktuelleGeschwindigkeit} von {maximaleGeschwindigkeit} und der Motor läuft ist {motorLaueft}";
        }

        public void StarteMotor()
        {
            if (motorLaueft != true)
            {
                motorLaueft = true;
                Console.WriteLine("Motor wurde gestartet");
            }
            else
            {
                Console.WriteLine("Motor läuft bereits");
            }
        }

        public void StoppeMotor()
        {
            if(motorLaueft == true && aktuelleGeschwindigkeit == 0)
            {
                motorLaueft = false;
                Console.WriteLine("Motor wurde gestoppt");
            }
            else if(motorLaueft == false){
                Console.WriteLine("Motor ist bereits aus");
            }
            else
            {
                Console.WriteLine("Das Fahrzeug steht nicht.");
            }
        }

        public void Beschleunige(int a)
        {
            if(aktuelleGeschwindigkeit + a <= maximaleGeschwindigkeit && aktuelleGeschwindigkeit + a >=0 && motorLaueft == true)
            {
                aktuelleGeschwindigkeit += a;
                Console.WriteLine($"Geschwindigkeit des Auto hat sich um {a} verändert");
            }
            else
            {
                Console.WriteLine("Unzulässige Geschwindigkeit als Endresultat oder Motor ist aus");
            }
        }
    }
}
