using csharp_scrabble_challenge.Main;
using System.Diagnostics.Tracing;

while (true)
{
    Console.WriteLine("Enter a word");

    string word = Console.ReadLine();
    
    Scrabble scrabble = new Scrabble(word);

    int score = scrabble.score();

    Console.WriteLine($"The score for {word} is {score}.");
}