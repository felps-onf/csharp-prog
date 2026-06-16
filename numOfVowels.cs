string [] vowels = ["a", "e", "i", "o", "u"];
int count = 0;
string word = "hello world";
foreach (char letter in word)
{
    if (vowels.Contains(letter.ToString()))
    {
        count++;
    }
}
Console.WriteLine("The number of vowels in the word \"" + word + "\" is: " + count);
