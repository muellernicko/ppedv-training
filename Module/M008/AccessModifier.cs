namespace M008
{
    public class AccessModifier
    {
        public int FeldPublic { get; set; } //überall sichtbar (Auch außerhalb vom Projekt)

        internal int FeldInternal { get; set; } // Überall sichtbar (aber nur innerhalb vom Projekt)

        private int FeldPrivate { get; set; } //Nur innerhalb des derzeitigen Typens sichtbar (nur zwischen den Klammern)

        protected int FeldProtected { get; set; } //nur innerhalb des derzeitigen Typens sichtbar, aber auch in Unterklassen

        protected internal int FeldProtectedInternal { get; set; }  // Überall sichtbar (Aber innerhalb vom Projekt) und in Unterklassen auch außerhalb vom Projekt
        protected private int FeldProtectedPrivate { get; set; }  // Nur innerhalb des derzeitigen Typens sichtbar, aber auch in Unterklassen (nur innerhalb)

    }
}