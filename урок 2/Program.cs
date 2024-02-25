// See https://aka.ms/new-console-template for more information
Console.WriteLine("salom!");
string salom = Console.ReadLine();

Console.WriteLine("nom va nasab!");
string nomvanasab = Console.ReadLine();
Console.WriteLine("salom " + nomvanasab);
Console.WriteLine("Mehohed ki ba banki mo mablag guzored!");
Console.ReadLine();
Console.WriteLine("Deposit mo dar yk moh 7% ast!");
Console.WriteLine("chan qadar mehohed deposit kuned?");
double summai_deposit = double.Parse(Console.ReadLine());//100

double mohiYakkumSumma = summai_deposit * 1.07;
Console.WriteLine($"Mohi yakum deposit: {mohiYakkumSumma}");

double mohiduyumsumma = mohiYakkumSumma * 1.07;
Console.WriteLine($"Mohi duyum: {mohiduyumsumma}");

double mohisevum = mohiduyumsumma * 1.07;
Console.WriteLine($"mohi sevum: {mohisevum}");
Console.WriteLine($"hamagi foida:{mohisevum-summai_deposit}");