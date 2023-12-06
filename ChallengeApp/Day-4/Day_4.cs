/*
 
    Dzień 4 - Zmienne i podstawowe operacje - zadanie domowe
    Dla zachowania porządku i katalogowania lekcji wykorzystuję osobne namespace

    Program.cs
    using ChallengeApp.Day_4;

    var Check = new Day_4();
    Check.MainFunction();

*/

namespace ChallengeApp.Day_4;

public class Day_4 {


    public void MainFunction() {
        var name = "Robert";
        var isWoman = false;
        var age = 31;

        var output = (name, isWoman, age) switch {
            ("Ewa", _, 33) => $"{name}, lat {age}",
            ("Robert", _, 31) => $"A to jestem ja, mam na imię {name} i mam {age} lat",
            (_, true, <30) => "Kobieta, poniżej 30 lat",
            (_, false, <18) => "Niepełnoletni Mężczyzna",
            (_) => "Dane nie spełniają żadnych kryteriów"
        };

        Console.WriteLine("Poniżej wynik po mojemu");
        Console.WriteLine(output);




        Console.WriteLine("\nPoniżej wynik z if'ów");

        if (name == "Ewa" && age == 33) {
            Console.WriteLine($"{name}, lat {age}");
        }
        else if (isWoman && age < 30) {
            Console.WriteLine("Kobieta, poniżej 30 lat");
        }
        else if (!isWoman && age < 18) {
            Console.WriteLine("Niepełnoletni Mężczyzna");
        }
        else if (name == "Robert" && age == 31) {
            Console.WriteLine($"A to jestem ja, mam na imię {name} i mam {age} lat");
        }
        else {
            Console.WriteLine("Dane nie spełniają żadnych kryteriów");
        }
    }
}
