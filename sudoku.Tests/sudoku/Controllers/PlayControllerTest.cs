using NUnit.Framework;

namespace usantatecla.sudoku.controllers
{
    public class PlayControllerTest
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Given_PlayController_WhenDontHasSudoku_ThenFalse()
        {
            PlayController playController  = new PlayController();
            Assert.IsFalse(playController.HasSudoku());
        }

        [Test]
        public void Given_PlayController_WhenHasSudoku_ThenTrue()
        {
            PlayController playController = new PlayController();
            Assert.IsTrue(!playController.HasSudoku());
        }
    }
}