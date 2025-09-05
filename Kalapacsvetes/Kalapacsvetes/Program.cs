using Kalapacsvetes;

string[] olvas = File.ReadAllLines("kalapacsvetes.txt");

List<Sportolo> sportolok = new List<Sportolo>();

foreach (string line in olvas.Skip(1))
{
    sportolok.Add(new Sportolo(line));
}

Console.WriteLine("4. feladat: {0} dobás eredménye található.", sportolok.Count);

double sum = 0;
int db = 0;

foreach (Sportolo e in sportolok)
{
    if (e.orszagkod == "HUN")
    {
        sum += e.eredmeny;
        db++;
    }
}

Console.WriteLine("5. feladat: A magyar sportolók átlagosan {0} métert dobtak.", sum / db);

Console.Write("Kérek egy évszámot: ");
string input=Console.ReadLine();

int darab = 0;

foreach (Sportolo e in sportolok)
{
    if (e.datum.Substring(0,4) ==input)
    {
        darab++;
        
    }
    
}
//Console.WriteLine(darab);

if (darab != 0)
{
    Console.WriteLine("{0}", darab);
    foreach (Sportolo e in sportolok)
    {
        if (e.datum.Substring(0, 4) == input)
        {
            Console.WriteLine(e.sportolo);

        }

    }
}
else
{
    Console.WriteLine("Nincs ilyen");
}

Console.WriteLine("7.feladat: Statisztika");

Dictionary<string, int> orszagok = new Dictionary<string, int>();
foreach(Sportolo k in sportolok)
{
    if (orszagok.ContainsKey(k.orszagkod))
    {
        orszagok[k.orszagkod]++;
    }
    else
    {
        orszagok.Add(k.orszagkod, 1);
    }
}

foreach(KeyValuePair<string, int> e in orszagok)
{
    Console.WriteLine("{0}-{1}",e.Key,e.Value);
}

Console.WriteLine("8.feladat");

StreamWriter magyar = new StreamWriter("magyarok.txt");

for (int i = 0; i <= sportolok.Count; i++)
{
    if (sportolok[i].orszagkod == "HUN")
    {
        magyar.WriteLine(sportolok[i]);
    }
}
magyar.Close();