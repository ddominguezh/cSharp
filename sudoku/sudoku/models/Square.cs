using System;

namespace usantatecla.sudoku.models
{
	public abstract class Square {

        protected Number Number;

        public Square(Number number)
        {
            this.Number = number;
        }

        public abstract bool CanAssign();
        public abstract bool IsEmpty();
        public abstract ConsoleColor GetColor();
	}
}