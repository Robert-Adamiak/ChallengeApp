namespace ChallengeApp.Day6;
public class Employee {
    private List<int> score = new List<int>();


    public Employee(string name, string surname, int age) {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public float ScoreAvg {
        get {

            return (float)Math.Round(score.Average(), Day6.AverageScoreDecimalNumbers);
        }
    }
    public float ScoreSum {
        get {

            return score.Sum();
        }
    }

    public void AddScore(int rating) {
        this.score.Add(rating);
    }


}
