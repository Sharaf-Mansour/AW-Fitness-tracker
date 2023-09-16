namespace AWFitnessTracker;
public record Activity(string ActivityType, TimeSpan Duration, double Distance, double CaloriesBurned)
{
    public override string ToString() => $"{ActivityType} ({Duration.TotalMinutes} minutes, {Distance} km, {CaloriesBurned} kcal burned)";
}