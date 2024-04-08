// See https://aka.ms/new-console-template for more information
// declare variables
string name = string.Empty;
int age = 0;
int retirementAge = 70;

Console.WriteLine("Enter your name:");
name = Console.ReadLine();
Console.WriteLine("Enter your current age:");
age = Convert.ToInt32(Console.ReadLine());
int workingYearsRemaining = retirementAge - age;

Console.WriteLine($"Employee's name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Years to retirement: {workingYearsRemaining}");


