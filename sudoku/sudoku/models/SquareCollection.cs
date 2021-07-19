using System;

namespace usantatecla.sudoku.models
{
	public class SquareCollection {

		private Square[] _squares;

        public SquareCollection(Square[] squares)
        {
            this._squares = squares;
        }

        public bool CanAssign(Number number) {
            return false;
        }

        public bool IsNotCompleted() => !IsCompleted();

        public bool IsCompleted()
        {
            return false;
        }

    }
}