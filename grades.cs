int [] grades = { 85, 92, 32, 90, 88 };

for (int i = 0; i < grades.Length; i++)
{
    if (grades[i] >= 65)
    {
        Console.WriteLine("Student " + (i + 1) + " passed with a grade of: " + grades[i]);
    }
    else
    {
        Console.WriteLine("Student " + (i + 1) + " failed with a grade of: " + grades[i]);
    }

}