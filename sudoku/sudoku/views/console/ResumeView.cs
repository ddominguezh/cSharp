using System;
using sudoku.controller;

namespace sudoku.views.console
{
    class ResumeView {

        private ResumeController resumeController;

        public ResumeView(ResumeController resumeController) {
            this.resumeController = resumeController;
        }

        public bool interact() {
            Console.WriteLine("Hello Sudoku Console Resume!");
            return false;
        }
    }
}