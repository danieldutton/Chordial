using Chordial.Luthier.Model;
using NUnit.Framework;

namespace Chordial.UnitTests.Luthier.Model
{
    [TestFixture]
    public class FretSpace_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectValue()
        {
            var sut = new FretSpace
            {
                Note = "A",
                XPos = 1,
                YPos = 1,
                ResourceName = "resource"
            };

            const string expected = "[FretSpace] Note:A XPos:1 YPos1 ResourceName:resource";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
