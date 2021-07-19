using System;
using usantatecla.sudoku.controllers;

namespace usantatecla.sudoku.views.console
{
    public class ResumeView {

        private ResumeController resumeController;

        public ResumeView(ResumeController resumeController) {
            this.resumeController = resumeController;
        }

        public bool Interact() {
            Console.WriteLine("Hello Sudoku Console Resume!");
            return false;
        }
    }
}