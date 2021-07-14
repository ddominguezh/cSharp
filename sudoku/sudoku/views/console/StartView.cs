using System;
using sudoku.controller;

namespace sudoku.views.console
{
    class StartView {

        private StartController startController;

        public StartView(StartController startController) {
            this.startController = startController;
        }

        public void interact() {
            Console.WriteLine("Hello Sudoku Console Start!");
        }
    }
}