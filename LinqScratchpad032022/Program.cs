// See https://aka.ms/new-console-template for more information


using LinqScratchpad032022;

List<int> list = new List<int> { 12, 34, 75, 1, 90, -24, 0, -42, 23, 11 };


//List<int> odds = new List<int>();
//foreach(int n in list)
//{
//    if (n % 2 == 1)
//    {
//        odds.Add(n);
//    }
//}

int pageStart = 0;
while (pageStart < list.Count)
{
    IEnumerable<int> listPage = list.Skip(pageStart).Take(3);
    foreach (int item in listPage)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("Press Enter...");
    Console.ReadLine();

    pageStart += 3;
}


IEnumerable<int> odds = list.Where(IsOdd);
int count = odds.Last();
list.Add(93);


foreach (int n in odds)
{
    Console.WriteLine(n);
}


//Console.WriteLine(odds.Count());


//var odds2 = from x in list
//            where x % 2 == 1
//            select x;

////List<int> evens = new List<int>();
////foreach (int n in list)
////{
////    if (n % 2 == 0)
////    {
////        evens.Add(n);
////    }
////}

//IEnumerable<int> evens = list.Where(x => x % 2 == 0);

//Console.WriteLine(evens.Count());


IEnumerable<int> triples = list.Select(x => x * 3);

foreach(int n in triples)
{
    Console.WriteLine(n);
}

IEnumerable<int> orderedList = list.OrderBy(x => x);
IEnumerable<int> reverseOrderedList = list.OrderBy(x => -x);
IEnumerable<int> reverseOrderedList2 = list.OrderByDescending(x => x);
IEnumerable<int> reverseOrderedList3 = list.OrderBy(x => x).Reverse();

//////////////////////////////////////////

List<Dog> dogs = new List<Dog>
{
    new Dog("Rover", 3, true),
    new Dog("Buddy", 6, true),
    new Dog("Spot", 1, false),
    new Dog("Giraldo", 11, true),
    new Dog("Hercules", 11, true),
    new Dog("Athena", 5, false),
    new Dog("Comma", 6, true),
    new Dog("Comet", 4, true),
    new Dog("Ajax", 2, false),
    new Dog("Roverina", 6, true),
    new Dog("Princess", 6, false)
};

IEnumerable<Dog> puppies = dogs.Where(d => d.Age < 4);

foreach(Dog d in puppies)
{
    Console.WriteLine(d.Name);
}

Console.WriteLine("---------------");

IEnumerable<string> dogNames = dogs.Select(d => d.Name);

foreach(string name in dogNames)
{
    Console.WriteLine(name);
}
Console.WriteLine("---------------");


IEnumerable<string> puppyNames = puppies.Select(p => p.Name);

foreach(string puppyName in puppyNames)
{
    Console.WriteLine(puppyName);
}

IEnumerable<Dog> newDogs = dogs.Select(d => new Dog(d.Name + " clone", d.Age / 2, true));

List<Dog> newDogList = newDogs.ToList();


List<string> hellos = dogs.Select(d => "Hello").ToList();


List<Dog> ageSortedDogs = dogs
    .OrderBy(d => d.Age)
    .ThenByDescending(d => d.Name)
    .ToList();


List<Dog> needVetVisitDogs = dogs.Where(d => d.Age < 4 || !d.IsVaccinated).ToList();

List<Dog> oldUnvaccinated = dogs
    .Where(d => d.Age > 3 && !d.IsVaccinated)
    .ToList();

List<Dog> oldUnvaccinated2 = dogs
    .Where(d => d.Age > 3)
    .Where(d => !d.IsVaccinated)
    .ToList();


Dog first = newDogs.First();
Dog firstOrDefault = newDogs.FirstOrDefault();
Dog last = newDogs.Last();
Dog lastOrDefault = newDogs.LastOrDefault();

Dog firstOld = dogs.FirstOrDefault(d => d.Age > 9999);

//Dog unvaccinatedDog = dogs.Single(d => !d.IsVaccinated);


int vaccinatedCount = dogs.Count(d => d.IsVaccinated);
int totalAge = dogs.Sum(d => d.Age);
double averageAge = dogs.Average(d => d.Age);
int highestAge = dogs.Max(d => d.Age);
bool allVaccinated = dogs.All(d => d.IsVaccinated);
bool anyVaccinated = dogs.Any(d => d.IsVaccinated);


List<Dog> oldestThree = dogs.OrderByDescending(d => d.Age).Take(3).ToList();
List<Dog> notYoungest = dogs.OrderBy(d => d.Age).Skip(3).ToList();
Dog fourthYoungest = dogs.OrderBy(d => d.Age).Skip(3).First();

Console.WriteLine("Done");







static bool IsOdd(int x)
{
    return x % 2 == 1;
}



