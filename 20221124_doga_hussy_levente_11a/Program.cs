Random rnd = new Random();

//1. Feladat
Console.WriteLine("Kérem adjon meg egy karakterláncot: ");
string Bekert = Console.ReadLine();
int VeletlenSzam = rnd.Next(0, 9);

for (int i = 0; i < VeletlenSzam; i++)
{
	if (VeletlenSzam % 2 == 0)
	{
		Console.Write($"{Bekert} ");
	}
	else
	{
		break;
	}
}

Console.WriteLine("\n-------------------------------------------------\n");


//2. Feladat
Console.Write("Maximálisan megengedett sebesség (kmph): ");
int MegengedettSebesseg = int.Parse(Console.ReadLine());
Console.Write("Tényleges sebesség (kmph): ");
int TenylegesSebesseg = int.Parse(Console.ReadLine());
if(MegengedettSebesseg > 50 || MegengedettSebesseg < 0)
{
	Console.Write("HIBA: ez a program csak 50kmph sebességkorlátig tudja meghatározni a bírságot.");
}
if(TenylegesSebesseg < MegengedettSebesseg)
{
	Console.WriteLine("Nem haladtad meg a sebességkorlátozást, nincs büntetés.");
}

int Kulonbseg = TenylegesSebesseg - MegengedettSebesseg;
if (TenylegesSebesseg > MegengedettSebesseg)
{
	if(Kulonbseg > 15 && Kulonbseg < 25)
	{
		Console.WriteLine($"A megengedett sebességet {Kulonbseg} kmph-val halattad meg, a kiszabott bírság összege: 30000 HUF");
	}
}

else if (TenylegesSebesseg > MegengedettSebesseg)
{
    if (Kulonbseg > 25 && Kulonbseg < 35)
    {
        Console.WriteLine($"A megengedett sebességet {Kulonbseg} kmph-val halattad meg, a kiszabott bírság összege: 45000 HUF");
    }
}
else if (TenylegesSebesseg > MegengedettSebesseg)
{
    if (Kulonbseg > 35 && Kulonbseg < 45)
    {
        Console.WriteLine($"A megengedett sebességet {Kulonbseg} kmph-val halattad meg, a kiszabott bírság összege: 60000 HUF");
    }
}
else if (TenylegesSebesseg > MegengedettSebesseg)
{
    if (Kulonbseg > 45 && Kulonbseg < 55)
    {
        Console.WriteLine($"A megengedett sebességet {Kulonbseg} kmph-val halattad meg, a kiszabott bírság összege: 90000 HUF");
    }
}
else if (TenylegesSebesseg > MegengedettSebesseg)
{
    if (Kulonbseg > 55 && Kulonbseg < 65)
    {
        Console.WriteLine($"A megengedett sebességet {Kulonbseg} kmph-val halattad meg, a kiszabott bírság összege: 130000 HUF");
    }
}
else if (TenylegesSebesseg > MegengedettSebesseg)
{
    if (Kulonbseg > 65 && Kulonbseg < 75)
    {
        Console.WriteLine($"A megengedett sebességet {Kulonbseg} kmph-val halattad meg, a kiszabott bírság összege: 200000 HUF");
    }
}
else if (TenylegesSebesseg > MegengedettSebesseg)
{
    if (Kulonbseg > 75)
    {
        Console.WriteLine($"A megengedett sebességet {Kulonbseg} kmph-val halattad meg, a kiszabott bírság összege: 300000 HUF");
    }
}



Console.WriteLine("\n-------------------------------------------------\n");

//3. Feladat
double Talalatok = 0;
for (int i = 0; i < 8; i++)
{
    double GeneraltSzam1 = rnd.Next(-99, 99);
    double GeneraltSzam2 = rnd.Next(-99, 99);
    Console.Write($"{i+1}.) {GeneraltSzam1} + {GeneraltSzam2} = ");
    double BekertSzam = double.Parse(Console.ReadLine());
    if (BekertSzam == GeneraltSzam1 + GeneraltSzam2)
    {
        Talalatok += 1;
    }
}
Console.WriteLine(Talalatok);
Console.WriteLine($"Az esetek {(Talalatok / 8) * 100:0.0}%-ában adtál helyes választ!");


