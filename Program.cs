namespace AWFitnessTracker;
class Program
{
    static void Main()
    {
        int age,height,weight,WorkoutDays;
        double activityLevel;
        Console.WriteLine("Please provide your information:");
        Console.WriteLine("Gender (male/female): ");
        string gender = Console.ReadLine();
        Console.WriteLine("Age: ");
        if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid age input. Please enter a valid integer.");
            return;
        }
        Console.WriteLine("Height (in cm): ");
        if (!int.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Invalid height input. Please enter a valid integer.");
            return;
        }
        Console.WriteLine("Weight (in kg): ");
        if (!int.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid weight input. Please enter a valid integer.");
            return;
        }
        Console.WriteLine("Activity Level (1. Sedentary, 2. Lightly Active, 3. Moderately Active, 4. Very Active, 5. Extremely Active): ");
        if (!double.TryParse(Console.ReadLine(), out activityLevel))
        {
            Console.WriteLine("Invalid activity level input. Please enter a valid number.");
            return;
        }
        Console.WriteLine("Enter your workout days to make the weekly schedule");
        if (!int.TryParse(Console.ReadLine(), out WorkoutDays))
        {
            Console.WriteLine("Invalid workout days. Please enter a valid integer.");
            return;
        }
        // Create a Userinfo instance with user-provided data
        var user = new Userinfo(gender, age, height, weight, activityLevel);
        user = new(gender, age, height, weight, activityLevel);
        // Calculate daily calorie intake for the user
        double dailyCalories = user.CalculateDailyCalorieIntake();
        Console.WriteLine($"Daily Calorie Intake: {dailyCalories} kcal");
        Console.WriteLine(user);
        Console.WriteLine(Workout.CalculateWorkoutSchedule(WorkoutDays));
    }
}