using System;
using System.Collections.Generic;

namespace usantatecla.sudoku.models
{
	public class Board {

		public static int SIZE = 9;

		private Square[,] _squares;

        public Board()
        {
			this._squares = new Square[SIZE, SIZE];
		}

		public void Load(string sudoku) { 
			
		}

		public void Assign(Assignment assignment)
		{

		}

		public bool CanAssign(Assignment assignment)
		{
			return false;
		}

		public bool HasSudoku()
		{
			return false;
		}

		public Square[,] GetBoard() => this._squares;

		public SquareCollection GetRow(Assignment assignment) {
			return new SquareCollection(NullArrayOfSquares());
		}

		public SquareCollection GetColumn(Assignment assignment)
		{
			return new SquareCollection(NullArrayOfSquares());
		}

		public SquareCollection GetBox(Assignment assignment)
		{
			return new SquareCollection(NullArrayOfSquares());
		}

		private Square[] NullArrayOfSquares() {
			return new Square[1];
		}
	}
}
