// See https://aka.ms/new-console-template for more information
Console.Write("Enter student's grade(0 to 100)");
int grade = Convert.ToInt32(Console.ReadLine());

/*
 * A 86 to 100
 * B 85 to 75
 * c 65 to 74
 * d 50 to 74
 * f less than 50
 */

if ((grade >= 0) && (grade <= 100))
{

    if (grade > 85)
    {
        Console.WriteLine("Student's grade is A! ");
    }
    else if (grade > 74)
    {
        Console.WriteLine("Student's grade is B! ");
    }
    else if (grade > 64)
    {
        Console.WriteLine("Student's grade is C! ");
    }
    else if (grade > 49)
    {
        Console.WriteLine("Student's grade is D! ");
    }
    else
    {
        Console.WriteLine("Student has failed! ");
    }
}
else
{
    Console.WriteLine("Enter valid grade from 0 to 100: 1");
}

