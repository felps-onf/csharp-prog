int [] scores  = { 85, 92, 78, 90, 88 };

for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] >= 90)
    {
        Console.WriteLine("Student " + (i + 1) + " received an A with a score of: " + scores[i]);
    }
    else if (scores[i] >= 80)
    {
        Console.WriteLine("Student " + (i + 1) + " received a B with a score of: " + scores[i]);
    }
    else if (scores[i] >= 70)
    {
        Console.WriteLine("Student " + (i + 1) + " received a C with a score of: " + scores[i]);
    }
    else if (scores[i] >= 60)
    {
        Console.WriteLine("Student " + (i + 1) + " received a D with a score of: " + scores[i]);
    }
    else
    {
        Console.WriteLine("Student " + (i + 1) + " received an F with a score of: " + scores[i]);
    }
}


