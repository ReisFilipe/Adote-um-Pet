// Test of modern C# features available in C# 12+ (with .NET 8.0+)

// Primary Constructors (C# 12)
var person = new Person("John", "Doe");
Console.WriteLine($"Name: {person.FirstName} {person.LastName}");

// Collection expressions (C# 12)
int[] numbers = [1, 2, 3, 4, 5];
Console.WriteLine($"Numbers: [{string.Join(", ", numbers)}]");

// Using a more compatible approach for nested arrays
int[][] matrix = [[1, 2], [3, 4]];
Console.WriteLine($"Matrix: [{string.Join(", ", matrix[0])}], [{string.Join(", ", matrix[1])}]");

Console.WriteLine("All modern C# features are working correctly!");

// Primary constructor example (C# 12)
public class Person(string firstName, string lastName)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
}
