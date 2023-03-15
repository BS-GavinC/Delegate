using Delegate.Models;

CarWash carWash = new CarWash();

Voiture voiture = new Voiture("1-ABC-234");
Voiture voiture2 = new Voiture("1-YZB-894");
Voiture voiture3 = new Voiture("2-JDG-990");

List<Voiture> voitures = new List<Voiture>();

voitures.Add(voiture);
voitures.Add(voiture2);
voitures.Add(voiture3);

Console.WriteLine("Selectionnez une voiture : ");

foreach (var v in voitures)
{
    Console.WriteLine($"{voitures.IndexOf(v) + 1} : {v.Plaque}");
}

int selectedCar = 0;

int.TryParse(Console.ReadLine(), out selectedCar);

Voiture selected = voitures[selectedCar - 1];

Console.WriteLine("Voulez vous que l'on prepare la voiture ?");

if (Console.ReadLine() == "y")
{
    carWash.Preparer();
}

Console.WriteLine("Voulez vous que l'on lave la voiture ?");

if (Console.ReadLine() == "y")
{
    carWash.Laver();
}

Console.WriteLine("Voulez vous que l'on seche la voiture ?");

if (Console.ReadLine() == "y")
{
    carWash.Secher();
}

Console.WriteLine("Voulez vous que l'on finalise la voiture ?");

if (Console.ReadLine() == "y")
{
    carWash.Finaliser();
}

Console.WriteLine("Preparation...");

carWash.Traiter(selected);


