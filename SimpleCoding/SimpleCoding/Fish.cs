namespace SimpleCoding;
public abstract class Fish : Animal
{
	public Fish(string name) : base(name)
	{
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{Name} буль-буль");
	}
}

public class Tuna : Fish
{
	public Tuna() : base("Тунець")
	{
		AddMovingType("water", 10);
	}
}

public class Salmon : Fish
{
	public Salmon() : base("Лосось")
	{
		AddMovingType("water", 8);
	}
}
public class GolderFish : Fish
{
	public GolderFish() : base("Золота\u2000риба")
	{
		AddMovingType("water", 6);
	}
}

public class FlyingFish : Fish
{
	public FlyingFish() : base("Риба\u2000летяга")
	{
		AddMovingType("air", 6);
		AddMovingType("water", 8);
	}
}
