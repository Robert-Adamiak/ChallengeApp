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
    public static int PersonalScoreDecimalNumbers { get; } = 0;
    public static int AverageScoreDecimalNumbers { get; } = 1;
    public static int MinRating { get; } = 1;
    public static int MaxRating { get; } = 10;
    public static int scoreCount = 5;

    public void MainFunction() {
        Employee? bestEmployee = null;

        var employeeList = new List<Employee>() {
        new Employee("Marcin","Kowalski",30),
        new Employee("Daniel","Obajtek",47),
        new Employee("Robert", "Adamiak", 31)
        };

        foreach (var employee in employeeList) {
            for (int i = 0; i < scoreCount; i++) {
                var randToAdd = GetRandomIntegerRating();
                Console.WriteLine($"Dodano ocenę {randToAdd} dla pracownika {employee.Name} {employee.Surname}");
                employee.AddScore(randToAdd);
            }
        }

        bestEmployee = CheckBestEmployeeBySumScore(employeeList);
        Console.WriteLine($"Najlepszy pracownik wedle sumy ocen to to {bestEmployee.Name} {bestEmployee.Surname} w wieku {bestEmployee.Age} lat z wynikiem {bestEmployee.ScoreSum}");



        bestEmployee = CheckBestEmployeeByAvgScore(employeeList);
        Console.WriteLine($"Najlepszy pracownik wedle średniej ocen to {bestEmployee.Name} {bestEmployee.Surname} w wieku {bestEmployee.Age} lat z wynikiem {bestEmployee.ScoreAvg}");



    }

    private int GetRandomIntegerRating() {
        var random = new Random();

        return (int)Math.Round(random.NextDouble() * (MaxRating - MinRating) + MinRating, PersonalScoreDecimalNumbers);
    }

    private Employee CheckBestEmployeeBySumScore(List<Employee> employeeList) {
        Employee? bestEmployee = null;

        foreach (var employee in employeeList) {
            if (bestEmployee == null) {
                bestEmployee = employee;
            }
            else {
                if (bestEmployee.ScoreSum < employee.ScoreSum) {
                    bestEmployee = employee;
                }
            }
        }

        return bestEmployee;
    }

    private Employee CheckBestEmployeeByAvgScore(List<Employee> employeeList) {
        Employee? bestEmployee = null;

        foreach (var employee in employeeList) {
            if (bestEmployee == null) {
                bestEmployee = employee;
            }
            else {
                if (bestEmployee.ScoreAvg < employee.ScoreAvg) {
                    bestEmployee = employee;
                }
            }
        }

        return bestEmployee;
    }


}
