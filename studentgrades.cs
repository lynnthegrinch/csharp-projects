Random dice = new();
int[] student1 = new int[5];
int[] student2 = new int[5];
int[] student3 = new int[5]; 
int[] student4 = new int[5];
int[] student5 = new int[5];
int student1total = 0;
int student2total = 0;
int student3total = 0;
int student4total = 0;
int student5total = 0;
decimal[] studentgrades = new decimal[5];

// assigning random grades
foreach (int i in student1)
{
    student1[i] = dice.Next(1, 101);
    student1total += student1[i];
}
decimal student1grade = (decimal) student1total / 5;
studentgrades[0] = student1grade;


foreach (int i in student2)
{
    student2[i] = dice.Next(1, 101);
    student2total += student2[i];
}
decimal student2grade= (decimal) student2total / 5;
studentgrades[1] = student2grade;


foreach (int i in student3)
{
    student3[i] = dice.Next(1, 101);
    student3total += student3[i];
}
decimal student3grade= (decimal) student3total / 5;
studentgrades[2]=student3grade;


foreach (int i in student4)
{
    student4[i] = dice.Next(1, 101);
    student4total += student4[i];
}
decimal student4grade= (decimal) student4total / 5;
studentgrades[3] = student4grade;


foreach (int i in student5)
{
    student5[i] = dice.Next(1, 101);
    student5total += student5[i];
}
decimal student5grade= (decimal) student5total / 5;
studentgrades[4]= student5grade;

// converting decimals to letters
string[] studentletters = new string[5];
foreach (decimal grade in studentgrades)
{
    int s= Array.IndexOf(studentgrades, grade);    
    if (grade>= 60) 
    {
        if (grade >= 70)
        { 
        if (grade >= 80)
            {
            if (grade >= 90)
                {
                    studentletters[s] = "A";
                }
            else
                {
                    studentletters[s] = "b";
                }
            }
            else
            {
                studentletters[s] = "c";
            }
        }
        else
        {
            studentletters[s] = "D";
        }
    }
    else
    {
        studentletters[s] = "f";
    }
}
Console.WriteLine("Student\t Dec\t Grade");
Console.WriteLine($"Sarah\t{studentgrades[0]}\t{studentletters[0]}");
Console.WriteLine($"Luca\t{studentgrades[1]}\t{studentletters[1]}");
Console.WriteLine($"Armando\t{studentgrades[2]}\t{studentletters[2]}");
Console.WriteLine($"Franco\t{studentgrades[3]}\t{studentletters[3]}");
Console.WriteLine($"Gioele\t{studentgrades[4]}\t{studentletters[4]}");


