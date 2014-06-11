using Chordial.FretBoardTemplate.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace Chordial.UnitTests
{
    [TestFixture]
    public class FretBoardBuilder_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetFretBoard_ThrowArgumentOutOfRangeEx_IfStringsLessThan1()
        {
            var sut = new FretBoardBuilder();

            sut.GetFretBoard(strings: 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetFretBoard_ThrowArgumentOutOfRangeEx_IfFretsLessThan1()
        {
            var sut = new FretBoardBuilder();

            sut.GetFretBoard(frets: 0);
        }

        [Test]
        public void GetFretBoard_WithSixStringsByDefault()
        {
            var sut = new FretBoardBuilder();

            Note[,] fretBoard = sut.GetFretBoard();

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_WithTwentyOneFretsByDefault()
        {
            var sut = new FretBoardBuilder();

            Note[,] fretBoard = sut.GetFretBoard();

            Assert.AreEqual(21, fretBoard.GetLength(1));
        }

        [Test]
        public void GetFretBoard_WithFourStrings()
        {
            var sut = new FretBoardBuilder();

            Note[,] fretBoard = sut.GetFretBoard(strings: 6, frets: 20);

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_WithSixStrings()
        {
            var sut = new FretBoardBuilder();

            Note[,] fretBoard = sut.GetFretBoard(strings: 6, frets: 20);

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_WithTwelveStrings()
        {
            var sut = new FretBoardBuilder();

            Note[,] fretBoard = sut.GetFretBoard(strings: 6, frets: 20);

            Assert.AreEqual(6, fretBoard.GetLength(0));
        }

        [Test]
        public void GetFretBoard_With21FretSpaces()
        {
            var sut = new FretBoardBuilder();

            Note[,] fretBoard = sut.GetFretBoard(strings: 6, frets: 10);

            Assert.AreEqual(10, fretBoard.GetLength(1));
        }

        [Test]
        public void GetFretBoard_AllInstancesAreOfType_Note()
        {
            var sut = new FretBoardBuilder();

            Note[] fretBoard = sut.GetFretBoard(strings:6, frets: 10)
                .Cast<Note>()
                .ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(fretBoard, typeof(Note));
        }

        #region string 1

        //should string positions be changed to exclude 0 to avoid confusion
        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_0()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 0].FretPositionX);
            Assert.AreEqual(0, result[0, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_1()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 1].FretPositionX);
            Assert.AreEqual(1, result[0, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_2()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 2].FretPositionX);
            Assert.AreEqual(2, result[0, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_3()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 3].FretPositionX);
            Assert.AreEqual(3, result[0, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_0_4()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(0, result[0, 4].FretPositionX);
            Assert.AreEqual(4, result[0, 4].FretPositionY);
        }

        #endregion

        #region string 2

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_0()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 0].FretPositionX);
            Assert.AreEqual(0, result[1, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_1()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 1].FretPositionX);
            Assert.AreEqual(1, result[1, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_2()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 2].FretPositionX);
            Assert.AreEqual(2, result[1, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_3()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 3].FretPositionX);
            Assert.AreEqual(3, result[1, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_1_4()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(1, result[1, 4].FretPositionX);
            Assert.AreEqual(4, result[1, 4].FretPositionY);
        }

        #endregion

        #region string 3

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_0()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 0].FretPositionX);
            Assert.AreEqual(0, result[2, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_1()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 1].FretPositionX);
            Assert.AreEqual(1, result[2, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_2()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 2].FretPositionX);
            Assert.AreEqual(2, result[2, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_3()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 3].FretPositionX);
            Assert.AreEqual(3, result[2, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_2_4()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(2, result[2, 4].FretPositionX);
            Assert.AreEqual(4, result[2, 4].FretPositionY);
        }

        #endregion

        #region string 4

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_0()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 0].FretPositionX);
            Assert.AreEqual(0, result[3, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_1()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 1].FretPositionX);
            Assert.AreEqual(1, result[3, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_2()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 2].FretPositionX);
            Assert.AreEqual(2, result[3, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_3()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 3].FretPositionX);
            Assert.AreEqual(3, result[3, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_3_4()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(3, result[3, 4].FretPositionX);
            Assert.AreEqual(4, result[3, 4].FretPositionY);
        }

        #endregion

        #region string 5

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_0()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 0].FretPositionX);
            Assert.AreEqual(0, result[4, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_1()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 1].FretPositionX);
            Assert.AreEqual(1, result[4, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_2()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 2].FretPositionX);
            Assert.AreEqual(2, result[4, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_3()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 3].FretPositionX);
            Assert.AreEqual(3, result[4, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_4_4()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(4, result[4, 4].FretPositionX);
            Assert.AreEqual(4, result[4, 4].FretPositionY);
        }

        #endregion

        #region string 6

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_0()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 0].FretPositionX);
            Assert.AreEqual(0, result[5, 0].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_1()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 1].FretPositionX);
            Assert.AreEqual(1, result[5, 1].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_2()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 2].FretPositionX);
            Assert.AreEqual(2, result[5, 2].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_3()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 3].FretPositionX);
            Assert.AreEqual(3, result[5, 3].FretPositionY);
        }

        [Test]
        public void GetFretBoard_InitNoteFretPositionPropertiesCorrectly_5_4()
        {
            var sut = new FretBoardBuilder();

            Note[,] result = sut.GetFretBoard(strings: 6, frets: 5);

            Assert.AreEqual(5, result[5, 4].FretPositionX);
            Assert.AreEqual(4, result[5, 4].FretPositionY);
        }

        #endregion
    }

    //we need to take into account the open notes.  The first column of the array should be used for this purpose
    //start drawing the actual grid from one onwards

    /*
     * The pitch of each consecutive fret is defined at a half-step interval on the chromatic scale. 
     * Standard classical guitars have 19 frets and electric guitars between 21 to 24 frets, although guitars 
     * have been made with as many as 27 frets
     * */
    
    public class FretBoardBuilder
    {
        private Note[,] _notes; //shouldnt this really be local

        public Note[,] GetFretBoard(int strings = 6, int frets = 21)
        {
            if(strings < 1) throw new ArgumentOutOfRangeException("strings");
            if(frets < 1) throw new ArgumentOutOfRangeException("frets");
            
            _notes = new Note[strings, frets];

            for (int i = 0; i < _notes.GetLength(0); i++)
            {
                for (int j = 0; j < _notes.GetLength(1); j++)
                {
                    _notes[i, j] = new Note
                    {
                        FretPositionX = i,
                        FretPositionY = j,
                    };
                }
            }
            return _notes;
        }
    }
}
