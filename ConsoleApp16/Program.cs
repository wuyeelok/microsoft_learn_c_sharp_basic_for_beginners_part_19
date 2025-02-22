Console.WriteLine("Hello World! OOP");

var p1 = new Person("John", "Doe", new DateOnly(1990, 1, 1));

var p2 = new Person("Ken", "Wu", new DateOnly(1989, 1, 1));

List<Person> people = [p1, p2];
Console.WriteLine(people.Count());

foreach (var person in people)
{
    Console.WriteLine($"{person.FirstName} {person.LastName} was born on {person.BirthDate}");
}


public class Person(string firstName, string lastName, DateOnly birthDate)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public DateOnly BirthDate { get; } = birthDate;


}

public class Mouse(string name)
{
    public string Name { get; } = name;

    public string Maze() => "I am in the maze";

}

public class Tiger(string name)
{
    public string Name { get; } = name;

    public string Hunt()
    {
        return "I am hunting";
    }
}
