namespace SimpleCoding;
public class Space
{
	public string Type { get; private set; }
	public int Duration { get; private set; }
	public ConsoleColor Color { get; private set; }

	public Space(string type, int duration, ConsoleColor color)
	{
		Type = type;
		Duration = duration;
		Color = color;
	}
}
