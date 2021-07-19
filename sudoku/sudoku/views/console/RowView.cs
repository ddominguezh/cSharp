using System;
using usantatecla.sudoku.models;

namespace usantatecla.sudoku.views.console
{
    public class RowView {

        private int _rowNumber;
        private Square[] _squares;

        public RowView(int rowNumber, Square[] squares) {
            this._rowNumber = rowNumber;
            this._squares = squares;
        }


        public void Display() {

        }
    }
}
 