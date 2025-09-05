
using autoapp;

string[] olvas = File.ReadAllLines("autok.csv"); 
List<Auto> adatok=new List<Auto>();

foreach (string line in olvas.Skip(1))
{
    adatok.Add(new Auto(line));
}

Console.WriteLine("5.feladat: {0} auto volt ",adatok.Count());

int darab = 0;
int eladott = 0;
foreach(Auto e in adatok)
{
    if (e.eladott!=0)
    {
        eladott+= e.eladott;
        darab++;
    }
}

double atlag = Math.Round((double)eladott / darab, 1);
Console.WriteLine(atlag);

Console.WriteLine("7.feladat: Az elmúlt 5 évben gyártott autók: ");

foreach(Auto e in adatok)
{
    if (e.gyartev)
}
