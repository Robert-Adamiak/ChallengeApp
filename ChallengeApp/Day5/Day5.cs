/*
 
    Dzień 5 - Tablice, Listy - zadanie domowe
    Dla zachowania porządku i katalogowania lekcji wykorzystuję osobne namespace

    Program.cs
    using ChallengeApp.Day5;

    var Check = new Day5();
    Check.MainFunction();

*/

namespace ChallengeApp.Day5;

public class Day5 {
    public void MainFunction() {
        var number = 1251544927;
        var numToString = number.ToString();
        var counts = new int[10];

        foreach (char item in numToString) {
            int digit = (int)Char.GetNumericValue(item);
            counts[digit]++;
        }

        Console.WriteLine($"Wyniki dla liczby: {number}");
        for (int i = 0; i < counts.Length; i++) {
            Console.WriteLine($"{i} => {counts[i]}");
        }
    }
}
