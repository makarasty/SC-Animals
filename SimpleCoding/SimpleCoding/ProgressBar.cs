using System;
using System.Threading;

namespace SimpleCoding
{
	public class ProgressBar
	{
		private int _barMaxWidth;
		private int _barIndex;
		private int _maxStringLength;
		private int _speed;
		private int _row;

		public ProgressBar(int maxStringLength, int barWidth, int speed, int row)
		{
			this._maxStringLength = maxStringLength;
			this._barMaxWidth = barWidth;
			this._speed = speed;
			this._barIndex = 0;
			this._row = row;
		}

		public void Draw()
		{
			int filledLength = Math.Min(this._barIndex, this._barMaxWidth);
			int spacesLength = this._barMaxWidth - filledLength;

			string bar = $"{new string('-', filledLength)}{new string(' ', spacesLength)}";
			string barWithFinish = $"{bar}[Finish]";

			Console.SetCursorPosition(0, this._row);
			Console.Write($"{barWithFinish.PadRight(this._maxStringLength)}\n");
		}

		public bool Update()
		{
			this._barIndex += this._speed;

			this.Draw();

			return this._barIndex >= this._barMaxWidth;
		}
	}
}
