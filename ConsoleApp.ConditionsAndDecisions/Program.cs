// See https://aka.ms/new-console-template for more information
Console.Write("Enter student's grade(0 to 100)");
int grade = Convert.ToInt32(Console.ReadLine());

if (grade > 80)
{
    Console.WriteLine("Student passed");
}

else
{
    Console.WriteLine("Student failed!");
}



