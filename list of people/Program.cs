using list_of_people;

List<Person> people = new List<Person>();

people.Add(new Person()
{
    Name = "Seif",
    Country = CountryEnum.EG,
    Age = 21
});

people.Add(new Person()
{
    Name = "Alxeander",
    Country = CountryEnum.UK,
    Age = 24
});

people.Add(new Person()
{
    Name = "Lio",
    Country = CountryEnum.PL,
    Age = 31
});

List<Person> results = people.OrderBy(p => p.Name).ToList();

foreach(Person person in results)
{
    Console.WriteLine($"{person.Name} ({person.Age} years) from {person.Country}.");
}

Console.WriteLine();

List<string> names = people.Where(p => p.Age <= 30)
    .OrderBy(p => p.Name)
    .Select(p => p.Name)
    .ToList();

Console.WriteLine(names.Count);
