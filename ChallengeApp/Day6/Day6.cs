/*
 
    Dzień 6: Klasy i metody w klasie - zadanie domowe
    Dla zachowania porządku i katalogowania lekcji wykorzystuję osobne namespace

    Program.cs
    using ChallengeApp.Day6;

    var Check = new Day6();
    Check.MainFunction();

*/

namespace ChallengeApp.Day6;

public class Day6 {
    public static int ScoreDecimalNumbers { get; } = 1;

    public void MainFunction() {

        var random = new Random();
        var min = 1.0f;
        var max = 10.0f;
        var scoreCount = 5;

        Employee? bestEmployee = null;

        var employeeList = new List<Employee>() {
        new Employee("Marcin","Kowalski",30),
        new Employee("Daniel","Obajtek",47),
        new Employee("Robert", "Adamiak", 31)
        };

        foreach (var employee in employeeList) {
            for (int i = 0; i < scoreCount; i++) {
                var randToAdd = (float)Math.Round(random.NextDouble() * (max - min) + min, ScoreDecimalNumbers);
                Console.WriteLine($"Dodano ocenę {randToAdd} dla pracownika {employee.Name} {employee.Surname}");
                employee.AddScore(randToAdd);
            }
        }


        foreach (var employee in employeeList) {
            if (bestEmployee == null) {
                bestEmployee = employee;
            }
            else {
                if (bestEmployee.Score < employee.Score) {
                    bestEmployee = employee;
                }
            }
        }

        Console.WriteLine($"Najlepszy pracownik to {bestEmployee.Name} {bestEmployee.Surname} w wieku {bestEmployee.Age} lat z wynikiem {bestEmployee.Score}");
    }
}
