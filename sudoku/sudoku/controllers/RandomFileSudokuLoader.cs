using System;

namespace usantatecla.sudoku.controllers
{
    public class RandomFileSudokuLoader : ISudokuLoader
    {
        private const string FILENAME = "";

        public RandomFileSudokuLoader()
        {

        }

        public string Load() { 
            return "53..7....6..195....98....6.8...6...34..8.3..17...2...6.6....28....419..5....8..79";
        }
    }
}