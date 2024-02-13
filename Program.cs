using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

Console.WriteLine("IELTS score average FOR academic");
string isContinued;
do
{
    Console.Write("Listening score: ");
    string listeningScoreInput = Console.ReadLine()!;

    Console.Write("Reading score: ");
    string readingScoreInput = Console.ReadLine()!;

    Console.Write("Speaking score: ");
    string speakingScoreInput = Console.ReadLine()!;

    Console.Write("Writing score: ");

    string writingScoreInput = Console.ReadLine()!;
    double[] scores={
        Convert.ToDouble(readingScoreInput),
        Convert.ToDouble(listeningScoreInput),
        Convert.ToDouble(writingScoreInput),
        Convert.ToDouble(speakingScoreInput)
        };
    double averageScore = scores.Average();
    double remainder = averageScore-(int)averageScore;
    remainder = remainder switch
    {
        _ when remainder < 0.25d => 0,
        _ when remainder < 0.75d => 0.5d,
        _ => 1,
    };

    averageScore=(int)averageScore+remainder;

    string scoreLevel = averageScore switch
    {
        _ when averageScore == 9 => "Expert",
        _ when averageScore >=8 && averageScore < 9 => "Very good",
        _ when averageScore >=7 && averageScore < 8 => "Good",
        _ when averageScore >=6 && averageScore < 7 => "Competent",
        _ when averageScore >=5 && averageScore < 6 => "Modest",
        _ => "This score is invalid"
    };

    Console.WriteLine($"Yours avreage score: {scoreLevel} {averageScore}");

    Console.Write("Do you want to continue Yes/No : ");
    isContinued = Console.ReadLine();
} while (isContinued.ToLower() == "yes");