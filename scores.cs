int [] scores = { 85, 92, 78, 90, 88 };
int sum = 0;
for (int i = 0; i < scores.Length; i++)
{
    sum += scores[i];
}
Console.WriteLine("The total score is: " + sum);

