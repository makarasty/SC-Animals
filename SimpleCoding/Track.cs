namespace SimpleCoding;
public class Track
{
	public int Distance { get; private set; }
	private List<Space> Steps { get; } = new List<Space>();
	private List<Animal> Animals { get; } = new List<Animal>();

	public Track(int distance)
	{
		Distance = distance;
	}

	public void AddSpace(string type, int duration)
	{
		Steps.Add(new Space(type, duration));
	}

	public void AddAnimal(Animal animal)
	{
		Animals.Add(animal);
	}

	public void Start()
	{
		bool needToContinue = true;

		while (needToContinue)
		{
			foreach (Animal animal in Animals)
			{
				foreach (var step in Steps)
				{
					animal.Move(step.Type);
					//? Thread.Sleep(100); ${Distance}
				}

				Console.WriteLine($"{animal.Name} пройшов трасу!");
				animal.MakeSound();
				Console.WriteLine("");

				if (animal.DistanceCovered >= Distance)
				{
					needToContinue = false;
				}
			}
		}

		var sortedAnimals = Animals.OrderByDescending(animal => animal.DistanceCovered).ToList();

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
			//                   ? якщо текст коротше чім 14 символів додає пробіли
			Console.WriteLine($"{animal.Name,-14}\t{animal.DistanceCovered} м");
		}

		Console.ForegroundColor = ConsoleColor.Blue;
		Console.WriteLine(new string('-', 40));
		Console.ResetColor();

		Console.WriteLine($"Переможець: {sortedAnimals.First().Name} 🏆");
	}
}