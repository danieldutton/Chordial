using Chordial.FretBoardTemplate;
using Chordial.FretBoardTemplate.Templates;
using NUnit.Framework;

namespace Chordial.UnitTests.FretBoardTemplate
{
    [TestFixture]
    public class SixStringElectricFretBoard_Should
    {
        [Test]
        public void B_HasSixStrings()
        {
            AbstractFretBoard sut = new Electric_6_StringFretBoard();

            Note[,] result = sut.GetFretBoard();

            Assert.AreEqual(6, result.GetLength(1));
        }

        [Test]
        public void B_HasTwentyFretSpaces()
        {
            AbstractFretBoard sut = new Electric_6_StringFretBoard();

            Note[,] result = sut.GetFretBoard();

            Assert.AreEqual(20, result.GetLength(0));
        }
    }
}
