
namespace SimpleCoding;

public class Track
{
	public int Distance { get; private set; }
	private List<Space> Steps { get; } = new List<Space>();
	private List<Animal> Animals { get; } = new List<Animal>();

	public Track(int distance)
	{
		this.Distance = distance;
	}

	public void AddSpace(string type, int duration, ConsoleColor color)
	{
		this.Steps.Add(new Space(type, duration, color));
	}

	public void AddAnimal(Animal animal)
	{
		this.Animals.Add(animal);
	}

	public void Start()
	{
		// Set the flag to continue the loop
		bool needToContinue = true;

		// Calculate the end cursor position
		int endCursorTop = Console.CursorTop + this.Animals.Count;

		// Reset the distance covered for all animals
		foreach (var animal in Animals)
		{
			animal.LastDistanceCovered = 0;
		}

		// Create a progress bar to display the progress of the animals
		ProgressBar progressBar = new ProgressBar(this, this.Animals, endCursorTop);

		// Loop until the condition is false
		while (needToContinue)
		{
			// Iterate through each step
			foreach (Space step in Steps)
			{
				// Iterate through each animal
				foreach (Animal animal in this.Animals)
				{
					// Move the animal and check if it can move
					bool canMove = animal.Move(step.Type);

					// If the animal can move, update the progress bar
					if (canMove)
					{
						progressBar.UpdateProgressBar(animal, step.Color);
					}

					// Check if the animal has covered the required distance
					if (animal.DistanceCovered >= this.Distance)
					{
						// Set the flag to stop the loop
						needToContinue = false;
						break;
					}
				}

				// If the flag is false, break the loop
				if (!needToContinue)
				{
					break;
				}

				// Pause for a short duration
				Thread.Sleep(100);

				// Update the animation symbol of the progress bar
				progressBar.UpdateAnimationSymbol();
			}
		}

		// Set the cursor position
		Console.SetCursorPosition(0, endCursorTop);

		// Sort the animals based on the distance covered in descending order
		List<Animal> sortedAnimals = this.Animals.OrderByDescending(animal => animal.DistanceCovered).ToList();

		// Print the table with the sorted animals
		PrintTable(sortedAnimals);
	}
	public static void PrintTable(List<Animal> sortedAnimals)
	{
		Console.WriteLine("\nРезультати гонки:");

		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(new string('-', 40));
		Console.ResetColor();

		Console.WriteLine("Тварина\t\tВідстань пройдена (м)");

		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(new string('-', 40));
		Console.ResetColor();

		foreach (Animal animal in sortedAnimals)
		{
			Console.WriteLine($"{animal.Name,-14}\t{animal.DistanceCovered} м");
		}

		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(new string('-', 40));
		Console.ResetColor();

		Console.WriteLine($"Переможець: {sortedAnimals.First().Name} 🏆");
	}
}