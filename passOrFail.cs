int [] studentsScores = { 45, 60, 72, 38, 55 };


for (int i = 0; i < studentsScores.Length; i++)
{
    if (studentsScores[i] >= 50)
    {
        Console.WriteLine("Student " + (i + 1) + " passed with a score of: " + studentsScores[i]);
    }
    else
    {
        Console.WriteLine("Student " + (i + 1) + " failed with a score of: " + studentsScores[i]);
    }
}
