using System;
using usantatecla.sudoku.models;

namespace usantatecla.sudoku.views.console
{
    public class ConsoleAssignmentParser {

        private string _action;

        public ConsoleAssignmentParser(string action) {
            this._action = action;
        }

        public Assignment Parse()
        {
            return new Assignment(new Coordinate(0,0), Number.EMPTY);
        }

        public bool HasError()
        {
            return false;
        }

        public void DisplayError() {

        }
    }
}
 