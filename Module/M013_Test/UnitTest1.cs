using M013;
namespace M013_Test;

public class RechnerTest
{

    //View --> Test Explorer

    //RM auf Projekt --> Add Project Reference --> Projekt ausw�hlen --> OK
    [TestMethod]
    public void TestAddiere()
    {
        Rechner r = new Rechner();

        double ergebnis = r.Addiere(4, 5);

        //Assert Klasse: Gibt die M�glichkeit, Testergebnnisse zu erzeugen
        Assert.AreEqual(9, ergebnis);
    }
}