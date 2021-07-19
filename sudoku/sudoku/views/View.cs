namespace sudoku.views
{
    public abstract class View {

        public void interact() {
            do {
                this.start();
                this.play();
            } while (this.isResumed());
        }

        protected abstract void start();
        protected abstract void play();
        protected abstract bool isResumed();

    }
}