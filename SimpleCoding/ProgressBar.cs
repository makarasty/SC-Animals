namespace SimpleCoding;

public class ProgressBar
{
	private int animationIndex = 0;
	private readonly char[] animationSymbols = new char[] { '/', '-', '\\', '|' };

	private readonly Track track;
	private readonly List<Animal> animals;
	private readonly int cursorTop;

	public ProgressBar(Track track, List<Animal> animals, int cursorTop)
	{
		this.track = track;
		this.animals = animals;
		this.cursorTop = cursorTop;
	}

	public void UpdateAnimationSymbol()
	{
		// Increment the animationIndex and wrap around to the beginning if it exceeds the length of animationSymbols
		animationIndex = (animationIndex + 1) % animationSymbols.Length;

		// Set the console cursor position to the beginning of the line
		Console.SetCursorPosition(0, cursorTop);

		// Write the new animation symbol at the current cursor position
		Console.Write(animationSymbols[animationIndex]);
	}

	public void UpdateProgressBar(Animal animal, ConsoleColor foreColor)
	{
		// Calculate the current distance covered by the animal
		int currentDistance = animal.DistanceCovered / 2;

		// Pad the animal name to have a fixed length of 14 characters
		string animalName = animal.Name.PadRight(14);

		// Get the index position of the animal in the list of animals
		int progressTop = animals.IndexOf(animal);

		// Set the cursor position to the start of the progress bar
		Console.SetCursorPosition(0, progressTop);

		// Write the animal name at the current cursor position
		Console.Write($"{animalName}");

		// Set the cursor position to the end of the progress bar
		Console.SetCursorPosition((track.Distance / 2) + animalName.Length, progressTop);

		// Write the finish marker at the current cursor position
		Console.Write("|Finish|");

		// Calculate the difference in distance covered since the last update
		int diff = currentDistance - animal.LastDistanceCovered;

		// Calculate the number of blocks to represent the progress
		int numBlocks = diff;

		// Set the cursor position to the current distance covered
		Console.SetCursorPosition(animal.LastDistanceCovered + animalName.Length, progressTop);

		// Set the console foreground color to the specified color
		Console.ForegroundColor = foreColor;

		// Write the progress blocks using the character '−'
		Console.Write(new string('−', numBlocks));

		// Reset the console foreground color to the default color
		Console.ResetColor();

		// Update the last distance covered by the animal
		animal.LastDistanceCovered = currentDistance;
	}
}