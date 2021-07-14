using sudoku.controller;

namespace sudoku.views.console
{
    public class View : sudoku.views.View {

        private StartView startView;
        private PlayView playView;
        private ResumeView resumeView;

        public View(StartController startController, PlayController playController, ResumeController resumeController) {
            this.startView = new StartView(startController);
            this.playView = new PlayView(playController);
            this.resumeView = new ResumeView(resumeController);
        }

        protected override void start(){
            this.startView.interact();
        }

        protected override void play(){
            this.playView.interact();
        }

        protected override bool isResumed(){
            return this.resumeView.interact();
        }
    }
}