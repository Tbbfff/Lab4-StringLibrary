using StringLibrary;

string[] words = ["Hello", "world", "Canada", "dotnet", "Azure"];

foreach (string word in words)
{
    Console.WriteLine($"{word} starts with uppercase: {word.StartsWithUpper()}");
}