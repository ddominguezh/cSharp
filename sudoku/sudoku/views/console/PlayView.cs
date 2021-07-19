using System;
using usantatecla.sudoku.controllers;

namespace usantatecla.sudoku.views.console
{
    public class PlayView {

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

        public void Interact() {
            Console.WriteLine("Hello Sudoku Console Play!");
        }
    }
}
 