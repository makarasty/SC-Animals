namespace SimpleCoding;
public abstract class Mammal : Animal
{
	public Mammal(string name) : base(name)
	{
	}

	public override void MakeSound(){}
}

public class Wolf : Mammal
{
	public Wolf() : base("Вовк")
	{
		AddMovingType("land", 5);
		AddMovingType("water", 2);
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{Name} Вуф вуф ауууф");
	}
}

public class Duck : Mammal
{
	public Duck() : base("Качка")
	{
		AddMovingType("land", 2);
		AddMovingType("water", 3);
		AddMovingType("air", 3);
	}
	public override void MakeSound()
	{
		Console.WriteLine($"{Name} кря кря");
	}
}

public class Horse : Mammal
{
	public Horse() : base("Конь")
	{
		AddMovingType("land", 6);
		AddMovingType("water", 2);
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{Name} Игого");
	}
}

public class Hepard : Mammal
{
	public Hepard() : base("Гепард")
	{
		AddMovingType("land", 8);
		AddMovingType("water", 1);
	}

	public override void MakeSound()
	{
		Console.WriteLine($"{Name} Мяу");
	}
}