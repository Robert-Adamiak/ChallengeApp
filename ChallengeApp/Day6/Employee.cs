namespace ChallengeApp.Day6;
public class Employee {
    private List<float> score = new List<float>();


    public Employee(string name, string surname, int age) {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public float Score {
        get {

            return (float)Math.Round(score.Average(), Day6.ScoreDecimalNumbers);
        }
    }

    public void AddScore(float rating) {
        this.score.Add(rating);
    }


}
