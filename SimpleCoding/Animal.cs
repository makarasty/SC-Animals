namespace SimpleCoding;
public abstract class Animal
{
	public string Name { get; private set; }
	protected Dictionary<string, int> MovingTypes { get; } = new Dictionary<string, int>();
	public string? CurrentActivity { get; private set; }
	public int DistanceCovered { get; private set; }

	protected Animal(string name)
	{
		Name = name;
	}

	public void AddMovingType(string spaceType, int speed)
	{
		MovingTypes[spaceType] = speed;
	}

	public void Move(string spaceType)
	{
		if (MovingTypes.ContainsKey(spaceType))
		{
			int speed = MovingTypes[spaceType];
			DistanceCovered += speed;
			Console.WriteLine($"{Name} рухається {spaceType} зі швидкістю {speed}.");
		}
		else
		{
			Console.WriteLine($"{Name} не вміє рухатися в просторі {spaceType}.");
		}
	}

	public void SetCurrentActivity(string activity)
	{
		CurrentActivity = activity;
	}

	public abstract void MakeSound();
}
