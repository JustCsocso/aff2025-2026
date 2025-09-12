
using autoapp;

string[] olvas = File.ReadAllLines("autok.csv"); 
List<Auto> adatok=new List<Auto>();

foreach (string line in olvas.Skip(1))
{
    adatok.Add(new Auto(line));
}

Console.WriteLine("5.feladat: {0} auto található a listában ",adatok.Count());

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
Console.WriteLine("6. feladat: Az autók esetében az átlagosan eladott darabszám: {0}",atlag);

Console.WriteLine("7.feladat: Az elmúlt 5 évben gyártott autók: ");

int ev = DateTime.Now.Year-1;
int kell= ev - 5;
foreach(Auto e in adatok)
{
    if (e.gyartev >= kell)
    {
        Console.WriteLine("\t- {0} {1}: {2}", e.marka, e.nev, e.gyartev);
    }
}

Console.WriteLine("8.feladat: A legsikeresebb márkák listája az eladott darabszám alapján:");

Dictionary<string, int> kocsi = new Dictionary<string, int>();

foreach(Auto e in adatok)
{
    if (e.eladott != 0)
    {
        if(kocsi.ContainsKey(e.marka))
        {
            kocsi[e.marka] += e.eladott;
        }
        else
        {
            kocsi.Add(e.marka, e.eladott);
        }
    }
}


foreach (var e in kocsi.OrderByDescending(x => x.Value))
{
    Console.WriteLine("\t- {0}: {1} db", e.Key, e.Value);
}
