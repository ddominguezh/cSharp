using System;

namespace usantatecla.sudoku.models
{
	public class PlayableSquare : Square 
	{
		public PlayableSquare() : base(Number.EMPTY) { }

		public override bool CanAssign() => true;
		public override bool IsEmpty() => this.Number == Number.EMPTY;
		public override ConsoleColor GetColor() => ConsoleColor.White;
	}
}