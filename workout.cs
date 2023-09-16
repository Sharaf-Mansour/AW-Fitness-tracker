
namespace AWFitnessTracker;
public static class Workout
{
    public static string CalculateWorkoutSchedule(int WorkoutDays) => WorkoutDays switch
    {
        2 or 4 => "Upper and lower program",
        3 or 6 => "Push and pull and legs",
        _ => "Custom workout schedule"
    };
}