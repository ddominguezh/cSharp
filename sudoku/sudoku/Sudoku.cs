using usantatecla.sudoku.controllers;
using usantatecla.sudoku.models;
using usantatecla.sudoku.views;

namespace usantatecla.sudoku
{
    public abstract class Sudoku {

        private Board _board;
        private StartController _startController;
        private PlayController _playController;
        private ResumeController _resumeController;
        private View _view;

        protected Sudoku() {
            this._board = new Board();
            this._startController = new StartController();
            this._playController = new PlayController();
            this._resumeController = new ResumeController();
            this._view = this.CreateView(this._startController, this._playController, this._resumeController);
        }

        protected abstract View CreateView(
            StartController startController, 
            PlayController playController, 
            ResumeController resumeController);

        protected void Play() => this._view.Interact();
    }
}