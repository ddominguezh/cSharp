using System;
using sudoku.controller;

namespace sudoku.views.console
{
    class PlayView {

        private PlayController playController;

        public PlayView(PlayController playController) {
            this.playController = playController;
        }

        /*
        void interact() {
            do {
                new GameView(this.playController).write();
            } while (!this.playController.isTicTacToe());
            new TokenView(this.playController.getToken()).write();
            Message.PLAYER_WIN.writeln();
        }
        */

        public void interact() {
            Console.WriteLine("Hello Sudoku Console Play!");
        }
    }
}
 