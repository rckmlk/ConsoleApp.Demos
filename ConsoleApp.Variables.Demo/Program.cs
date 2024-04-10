// See https://aka.ms/new-console-template for more information
// declare variables
string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 70;
decimal salary = 0;
char gender = char.MinValue;
bool working = false;



Console.WriteLine("Enter your first name:");
firstName = Console.ReadLine();

Console.WriteLine("Enter your last name:");
lastName = Console.ReadLine();


Console.WriteLine("Enter your current age:");
age = Convert.ToInt32(Console.ReadLine());
int workingYearsRemaining = retirementAge - age;

Console.WriteLine($"Employee's name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Years to retirement: {workingYearsRemaining}");


