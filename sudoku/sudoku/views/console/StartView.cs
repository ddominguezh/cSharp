using System;
using usantatecla.sudoku.controllers;

namespace usantatecla.sudoku.views.console
{
    public class StartView {

        private StartController startController;

        public StartView(StartController startController) {
            this.startController = startController;
        }

        public void Interact() {
            Console.WriteLine("Hello Sudoku Console Start!");
        }
    }
}