using sudoku.controller;
using sudoku.views;

namespace sudoku
{
    public abstract class Sudoku {

        //private Game game;
        private StartController startController;
        private PlayController playController;
        private ResumeController resumeController;
        private View view;

        protected Sudoku() {
            //this.game = new Game();
            //this.startController = new StartController(this.game);
            //this.playController = new PlayController(this.game);
            //this.resumeController = new ResumeController(this.game);
            //this.view = this.createView(this.startController, this.playController, this.resumeController);

            this.startController = new StartController();
            this.playController = new PlayController();
            this.resumeController = new ResumeController();
            this.view = this.createView(this.startController, this.playController, this.resumeController);
        }

        protected abstract View createView(StartController startController, PlayController playController, ResumeController resumeController2);

        protected void play() {
            this.view.interact();
        }
    }
}