namespace SimpleCoding;
public abstract class Bird : Animal
{
	public Bird(string name) : base(name)
	{
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{Name} звук птиці");
	}
}

public class Crow : Bird
{
	public Crow() : base("Ворон")
	{
		AddMovingType("land", 2);
		AddMovingType("air", 5);
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{Name} кар кар");
	}
}

public class Parrot : Bird
{
	public Parrot() : base("Папугай")
	{
		AddMovingType("land", 1);
		AddMovingType("air", 4);
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{Name} *какие-то человечиские звуки*");
	}
}