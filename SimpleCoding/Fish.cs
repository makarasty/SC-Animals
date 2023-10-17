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
		AddMovingType("water", 3);
	}
}

public class Salmon : Fish
{
	public Salmon() : base("Лосось")
	{
		AddMovingType("water", 2);
	}
}
public class GolderFish : Fish
{
	public GolderFish() : base("Золота\u2000риба")
	{
		AddMovingType("water", 1);
	}
}

public class FlyingFish : Fish
{
	public FlyingFish() : base("Риба\u2000летяга")
	{
		AddMovingType("air", 1);
		AddMovingType("water", 4);
	}
}
