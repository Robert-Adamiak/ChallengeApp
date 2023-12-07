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

    public static int scoreCount = 5;

    public void MainFunction() {
        int minRating = 1;
        int maxRating = 10;

        Employee? bestEmployee = null;

        var employeeList = new List<Employee>() {
        new Employee("Marcin","Kowalski",30),
        new Employee("Daniel","Obajtek",47),
        new Employee("Robert", "Adamiak", 31)
        };

        foreach (var employee in employeeList) {
            for (int i = 0; i < scoreCount; i++) {
                var randToAdd = Employee.GetRandomIntegerRating(maxRating, minRating,PersonalScoreDecimalNumbers);
                Console.WriteLine($"Dodano ocenę {randToAdd} dla pracownika {employee.Name} {employee.Surname}");
                employee.AddScore(randToAdd);
            }
        }

        bestEmployee = Employee.CheckBestEmployeeBySumScore(employeeList);
        Console.WriteLine($"Najlepszy pracownik wedle sumy ocen to to {bestEmployee.Name} {bestEmployee.Surname} w wieku {bestEmployee.Age} lat z wynikiem {bestEmployee.ScoreSum}");



        bestEmployee = Employee.CheckBestEmployeeByAvgScore(employeeList);
        Console.WriteLine($"Najlepszy pracownik wedle średniej ocen to {bestEmployee.Name} {bestEmployee.Surname} w wieku {bestEmployee.Age} lat z wynikiem {bestEmployee.ScoreAvg}");



    }








}
