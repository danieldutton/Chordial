using Chordial.FretBoardTemplate;
using Chordial.FretBoardTemplate.Templates;
using NUnit.Framework;

namespace Chordial.UnitTests.FretBoardTemplate
{
    [TestFixture]
    public class SixStringAcousticFretBoard_Should
    {
        [Test]
        public void A_HasSixStrings()
        {
            AbstractFretBoard sut = new Acoustic6StringFretBoard();

            Note[,] result = sut.GetFretBoard();

            Assert.AreEqual(6, result.GetLength(1));
        }

        [Test]
        public void A_HasTwentyFretSpaces()
        {
            AbstractFretBoard sut = new Acoustic6StringFretBoard();

            Note[,] result = sut.GetFretBoard();

            Assert.AreEqual(20, result.GetLength(0));
        }

        
    }
}
