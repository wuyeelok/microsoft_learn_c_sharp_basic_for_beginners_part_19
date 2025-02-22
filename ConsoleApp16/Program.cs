Console.WriteLine("Hello World! OOP");

var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));
p1.Pets.Add(new Tiger("Tiger1"));
p1.Pets.Add(new Tiger("Tiger2"));
p1.Pets.Add(new Tiger("Tiger4"));

var p2 = new Person("Ken", "Wu", new DateOnly(1989, 1, 1));
p2.Pets.Add(new Mouse("Mouse1"));
p2.Pets.Add(new Tiger("Tiger3"));

List<Person> people = [p1, p2];
Console.WriteLine(people.Count());

foreach (var person in people)
{
    Console.WriteLine(person);
}


public class Person(string firstName, string lastName, DateOnly birthDate)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public DateOnly BirthDate { get; } = birthDate;


    public List<Pet> Pets { get; } = [];

    public override string ToString()
    {
        var petGreet = "";
        foreach (var pet in Pets)
        {
            petGreet += pet.ToString() + " ";
        }
        return $"{FirstName} {LastName} was born on {BirthDate}, has number of {Pets.Count()} pets.\n{petGreet}";
    }
}

public abstract class Pet(string name)
{
    public string Name { get; } = name;

    public abstract string MakeNoise();

    public override string ToString()
    {
        return $"{Name} and I am a {GetType().Name}!  And I make noise {MakeNoise()}!";
    }
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
