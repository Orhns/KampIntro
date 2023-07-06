

string title = "BootCamp";
string egitmen = "Engin Demiroğ";
int izlenmeOrani = 68;

Kurs kurs1 = new Kurs();
kurs1.Egitmen = egitmen;
kurs1.KursAdi = title;
kurs1.IzlenmeOrani = izlenmeOrani;

Kurs kurs2 = new Kurs();
kurs2.Egitmen = "Orhun";
kurs2.KursAdi = "java";
kurs2.IzlenmeOrani = 13;

Kurs kurs3 = new Kurs();
kurs3.Egitmen = "Jax";
kurs3.KursAdi = "C#";
kurs3.IzlenmeOrani = 50;

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmen + " - " + kurs.IzlenmeOrani + "///");
}
class Kurs
{
    public string? KursAdi { get; set; }
    public string? Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}