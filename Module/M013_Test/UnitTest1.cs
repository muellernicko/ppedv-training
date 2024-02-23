using M013;
namespace M013_Test;

public class RechnerTest
{

    //View --> Test Explorer

    //RM auf Projekt --> Add Project Reference --> Projekt auswählen --> OK
    [TestMethod]
    public void TestAddiere()
    {
        Rechner r = new Rechner();

        double ergebnis = r.Addiere(4, 5);

        //Assert Klasse: Gibt die Möglichkeit, Testergebnnisse zu erzeugen
        Assert.AreEqual(9, ergebnis);
    }
}