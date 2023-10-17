namespace SimpleCoding;
public abstract class Animal
{
	public string Name { get; private set; }
	protected Dictionary<string, int> MovingTypes { get; } = new Dictionary<string, int>();
	public string? CurrentActivity { get; private set; }
	public int DistanceCovered { get; private set; }
	public int LastDistanceCovered;

	protected Animal(string name)
	{
		this.Name = name;
	}

	public void AddMovingType(string spaceType, int speed)
	{
		this.MovingTypes[spaceType] = speed;
	}

	public bool Move(string spaceType)
	{
		bool canMove = this.MovingTypes.ContainsKey(spaceType);
		if (canMove)
		{
			int speed = this.MovingTypes[spaceType];

			this.DistanceCovered += speed;
			//Console.WriteLine($"{Name} рухається {spaceType} зі швидкістю {speed}.");
		}
		else
		{
			//Console.WriteLine($"{Name} не вміє рухатися в просторі {spaceType}.");
		}
		return canMove;
	}

	public void SetCurrentActivity(string activity)
	{
		this.CurrentActivity = activity;
	}

	public abstract void MakeSound();
}
