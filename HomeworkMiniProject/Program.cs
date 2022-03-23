

string? firstName;
int? age;

Console.Write("Hello, please enter your name: ");
firstName = Console.ReadLine();

Console.Write("Thank you. Next, please enter your age: ");
age = Int32.Parse(Console.ReadLine());


if (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    Console.WriteLine("Hello professor, welcome to my application.");
}
else
{
    Console.WriteLine($"Hello {firstName}, Welcome to my application.");
}

if (age < 21)
{
    Console.WriteLine($"It is recommended that you wait {21 - age} year(s) to start this class.");
}