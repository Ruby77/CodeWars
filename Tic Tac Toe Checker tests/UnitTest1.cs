using NUnit.Framework;
using Tic_Tac_Toe_Checker;

namespace Tic_Tac_Toe_Checker_tests
{
    [TestFixture]
    public class Tests
    {
        private Program tictactoe = new Program();
        [Test]
        public void test1()
        {
            int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(1, tictactoe.IsSolved(board));
        }
    }
}