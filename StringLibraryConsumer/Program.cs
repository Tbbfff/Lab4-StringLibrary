using StringLibrary;

string[] words = { "Hello", "world", "Bruno", "csharp", "Azure" };

foreach (var word in words)
{
    Console.WriteLine($"'{word}' starts with uppercase: {word.StartsWithUpper()}");
}