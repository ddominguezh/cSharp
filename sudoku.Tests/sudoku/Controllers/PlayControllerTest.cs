using NUnit.Framework;

namespace sudoku.controller
{
    public class SudokuTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PlayControllerTest()
        {
            PlayController playController  = new PlayController();
            Assert.IsFalse(playController.HasSudoku());
        }
    }
}