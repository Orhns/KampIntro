


string kredi1 = "Hızlı kredi";
string kredi2 = "Maaşını halkbanktan ..";
string kredi3 = "Mutlu Emekli";

string[] krediler = new string[] {kredi1, kredi2, kredi3};

for (int i = 0; i < krediler.Length; i++)
{
    Console.WriteLine(krediler[i]);  
    //System.Console.WriteLine(krediler.GetValue(i));
}

Console.WriteLine("-----------------------------------------");

foreach (var x in krediler)
{
    Console.WriteLine(x);
}
