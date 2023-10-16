namespace SimpleCoding;
public class Space
{
	public string Type { get; private set; }
	public int Duration { get; private set; }

	public Space(string type, int duration)
	{
		Type = type;
		Duration = duration;
	}
}
