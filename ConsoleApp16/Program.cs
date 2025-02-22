using System.Diagnostics.Contracts;

Console.WriteLine("Hello World! OOP");

var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));
p1.Pets.Add(new Tiger("Tiger1"));
p1.Pets.Add(new Tiger("Tiger2"));

var p2 = new Person("Ken", "Wu", new DateOnly(1989, 1, 1));
p2.Pets.Add(new Mouse("Mouse1"));
p2.Pets.Add(new Tiger("Tiger3"));

List<Person> people = [p1, p2];
Console.WriteLine(people.Count());

foreach (var person in people)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} was born on {person.BirthDate}, has {person.Pets.Count()} pets");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"{pet.Name} makes noise {pet.MakeNoise()}");
    }
}


public class Person(string firstName, string lastName, DateOnly birthDate)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public DateOnly BirthDate { get; } = birthDate;


    public List<Pet> Pets { get; } = [];
}

public abstract class Pet(string name)
{
    public string Name { get; } = name;

    public abstract string MakeNoise();
}

public class Mouse(string name) : Pet(name)
{

    public override string MakeNoise()
    {
        return "Maze Maze";
    }
}



public class Tiger(string name) : Pet(name)
{
    public override string MakeNoise()
    {
        return "Roar";
    }

}
