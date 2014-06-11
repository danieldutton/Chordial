using System.Linq;
using Chordial.FretboardBuilder;
using NUnit.Framework;
using System;

namespace Chordial.UnitTests
{
    [TestFixture]
    public class FretBoardBuilder_Should
    {
        private FretboardGenerator _sut;

        [SetUp]
        public void Init()
        {
            _sut = new FretboardGenerator();    
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetFretBoard_ThrowArgumentOutOfRangeEx_IfStringsLessThan1()
        {
            _sut.GetFretBoard(strings: 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetFretBoard_ThrowArgumentOutOfRangeEx_IfFretsLessThan1()
        {
            _sut.GetFretBoard(frets: 0);
        }

        [Test]
        public void GetFretBoard_WithSixStringsByDefault()
        {
            Note[,] fretBoard = _sut.GetFretBoard();

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_WithTwentyOneFretsByDefault()
        {
            Note[,] fretBoard = _sut.GetFretBoard();

            Assert.AreEqual(21, fretBoard.GetLength(1));
        }

        [Test]
        public void GetFretBoard_WithFourStrings()
        {
            Note[,] fretBoard = _sut.GetFretBoard(strings: 6, frets: 20);

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_WithSixStrings()
        {
            Note[,] fretBoard = _sut.GetFretBoard(strings: 6, frets: 20);

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_WithTwelveStrings()
        {
            Note[,] fretBoard = _sut.GetFretBoard(strings: 6, frets: 20);

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_With21FretSpaces()
        {
            Note[,] fretBoard = _sut.GetFretBoard(strings: 6, frets: 10);

            Assert.AreEqual(10, fretBoard.GetLength(1));
        }

        [Test]
        public void GetFretBoard_AllInstancesAreOfType_Note()
        {
            Note[] fretBoard = _sut.GetFretBoard(strings:6, frets: 10)
                .Cast<Note>()
                .ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(fretBoard, typeof(Note));
        }

        #region string 1

        //should string positions be changed to exclude 0 to avoid confusion
        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_0()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 0].FretPositionX);
            Assert.AreEqual(0, result[0, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_1()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 1].FretPositionX);
            Assert.AreEqual(1, result[0, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_2()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 2].FretPositionX);
            Assert.AreEqual(2, result[0, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_3()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 3].FretPositionX);
            Assert.AreEqual(3, result[0, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_4()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 4].FretPositionX);
            Assert.AreEqual(4, result[0, 4].FretPositionY);
        }

        #endregion

        #region string 2

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_0()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 0].FretPositionX);
            Assert.AreEqual(0, result[1, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_1()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 1].FretPositionX);
            Assert.AreEqual(1, result[1, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_2()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 2].FretPositionX);
            Assert.AreEqual(2, result[1, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_3()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 3].FretPositionX);
            Assert.AreEqual(3, result[1, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_4()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 4].FretPositionX);
            Assert.AreEqual(4, result[1, 4].FretPositionY);
        }

        #endregion

        #region string 3

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_0()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 0].FretPositionX);
            Assert.AreEqual(0, result[2, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_1()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 1].FretPositionX);
            Assert.AreEqual(1, result[2, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_2()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 2].FretPositionX);
            Assert.AreEqual(2, result[2, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_3()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 3].FretPositionX);
            Assert.AreEqual(3, result[2, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_4()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 4].FretPositionX);
            Assert.AreEqual(4, result[2, 4].FretPositionY);
        }

        #endregion

        #region string 4

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_0()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 0].FretPositionX);
            Assert.AreEqual(0, result[3, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_1()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 1].FretPositionX);
            Assert.AreEqual(1, result[3, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_2()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 2].FretPositionX);
            Assert.AreEqual(2, result[3, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_3()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 3].FretPositionX);
            Assert.AreEqual(3, result[3, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_4()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 4].FretPositionX);
            Assert.AreEqual(4, result[3, 4].FretPositionY);
        }

        #endregion

        #region string 5

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_0()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 0].FretPositionX);
            Assert.AreEqual(0, result[4, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_1()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 1].FretPositionX);
            Assert.AreEqual(1, result[4, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_2()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 2].FretPositionX);
            Assert.AreEqual(2, result[4, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_3()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 3].FretPositionX);
            Assert.AreEqual(3, result[4, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_4()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 4].FretPositionX);
            Assert.AreEqual(4, result[4, 4].FretPositionY);
        }

        #endregion

        #region string 6

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_0()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 0].FretPositionX);
            Assert.AreEqual(0, result[5, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_1()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 1].FretPositionX);
            Assert.AreEqual(1, result[5, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_2()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 2].FretPositionX);
            Assert.AreEqual(2, result[5, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_3()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 3].FretPositionX);
            Assert.AreEqual(3, result[5, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_4()
        {
            Note[,] result = _sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 4].FretPositionX);
            Assert.AreEqual(4, result[5, 4].FretPositionY);
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }

    
}
