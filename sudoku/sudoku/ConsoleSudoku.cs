using System;
using sudoku.controller;
using sudoku.views.console;

namespace sudoku
{
    class ConsoleSudoku : Sudoku
    {
        
        protected override View createView(StartController startController, PlayController playController, ResumeController resumeController){
            return new View(startController, playController, resumeController);
        }

        static void Main(string[] args)
        {
            new ConsoleSudoku().play();
        }
    }
}
