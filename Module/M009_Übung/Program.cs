namespace M009_Übung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug[] fuhrpark = new Fahrzeug[10];
            fuhrpark[0] = Fahrzeug.GeneriereFahrzeug("Hans Peter");
            fuhrpark[1] = Fahrzeug.GeneriereFahrzeug("Hans Wurst");
            fuhrpark[2] = Fahrzeug.GeneriereFahrzeug("R2D2");
            fuhrpark[3] = Fahrzeug.GeneriereFahrzeug("Leopard 2");
            fuhrpark[4] = Fahrzeug.GeneriereFahrzeug("C3PO");
            fuhrpark[5] = Fahrzeug.GeneriereFahrzeug("Wall-e");
            fuhrpark[6] = Fahrzeug.GeneriereFahrzeug("Michael Jackson");
            fuhrpark[7] = Fahrzeug.GeneriereFahrzeug("Jack the ripper");
            fuhrpark[8] = Fahrzeug.GeneriereFahrzeug("Die drei ???");
            fuhrpark[8] = Fahrzeug.GeneriereFahrzeug("Nickos Auto");
            fuhrpark[9] = Fahrzeug.GeneriereFahrzeug("Lukas Auto");


            int pkws = 0;
            int schiffe = 0;
            int flugzeuge = 0;

            foreach (Fahrzeug fw in fuhrpark)
            {
                if (fw is PKW)
                    pkws++;
                if (fw is Schiff)
                    schiffe++;
                if (fw is Flugzeug)
                    flugzeuge++;
            }

            Console.WriteLine($"Es wurden {pkws} PKW, {schiffe} Schiff(e) und {flugzeuge} Flugzeug(e) produziert.");

            fuhrpark[2].Hupen();

        }
    }
}