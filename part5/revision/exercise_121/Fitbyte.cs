
namespace exercise_121
{
    public class Fitbyte
    {
        public int age;
        public int restingHeartRate;

        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }
        public double TargetHeartRate(double percentageOfMaximum)
        {
            double maxHeartRate = 206.3 - (0.711 * age);
            return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate; 
        }
    }
}