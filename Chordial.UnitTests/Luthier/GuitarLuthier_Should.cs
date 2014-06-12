using Chordial.Luthier;
using Chordial.Tuner.Model;
using NUnit.Framework;
using System;
using System.Linq;

namespace Chordial.UnitTests.Luthier
{
    //Tests assume a six string guitar with fret lengths 20 & 24

    [TestFixture]
    public class GuitarLuthier_Should
    {
        private GuitarLuthier _sut;

        [SetUp]
        public void Init()
        {
            _sut = new GuitarLuthier();   
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BuildInstrument_ThrowArgumentOutOfRangeEx_IfStringsLessThan1()
        {
            _sut.BuildInstrument(strings: 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BuildInstrument_ThrowArgumentOutOfRangeEx_IfFretsLessThan1()
        {
            _sut.BuildInstrument(frets: 0);
        }

        [Test]
        public void BuildInstrument_WithSixStringsByDefault()
        {
            Note[,] guitar = _sut.BuildInstrument();

            Assert.AreEqual(6, guitar.GetLength(0));
        }

        [Test]
        public void BuildInstrument_WithTwentyFourFretSpacesByDefault()
        {
            Note[,] guitar = _sut.BuildInstrument();

            Assert.AreEqual(24, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_WithSixStrings()
        {
            Note[,] guitar = _sut.BuildInstrument(6);

            Assert.AreEqual(6, guitar.GetLength(0));
        }

        [Test]
        public void BuildInstrument_WithTwentyFretSpaces()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 10);

            Assert.AreEqual(10, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_WithTwentyFourFretSpaces()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 10);

            Assert.AreEqual(10, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_AllFretSpacesAreOfType_Note()
        {
            Note[] guitar = _sut.BuildInstrument(strings:6, frets: 10)
                .Cast<Note>()
                .ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(guitar, typeof(Note));
        }

        //GuitarString 1 - ELow

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_0()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 0].FretPositionX);
            Assert.AreEqual(0, guitar[0, 0].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_1()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 1].FretPositionX);
            Assert.AreEqual(1, guitar[0, 1].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_2()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 2].FretPositionX);
            Assert.AreEqual(2, guitar[0, 2].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_3()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 3].FretPositionX);
            Assert.AreEqual(3, guitar[0, 3].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_4()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 4].FretPositionX);
            Assert.AreEqual(4, guitar[0, 4].FretPositionY);
        }

        //GuitarString 2 - A

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_0()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 0].FretPositionX);
            Assert.AreEqual(0, guitar[1, 0].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_1()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 1].FretPositionX);
            Assert.AreEqual(1, guitar[1, 1].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_2()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 2].FretPositionX);
            Assert.AreEqual(2, guitar[1, 2].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_3()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 3].FretPositionX);
            Assert.AreEqual(3, guitar[1, 3].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_4()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 4].FretPositionX);
            Assert.AreEqual(4, guitar[1, 4].FretPositionY);
        }

        //GuitarString 3 - D

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_0()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 0].FretPositionX);
            Assert.AreEqual(0, guitar[2, 0].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_1()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 1].FretPositionX);
            Assert.AreEqual(1, guitar[2, 1].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_2()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 2].FretPositionX);
            Assert.AreEqual(2, guitar[2, 2].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_3()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 3].FretPositionX);
            Assert.AreEqual(3, guitar[2, 3].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_4()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 4].FretPositionX);
            Assert.AreEqual(4, guitar[2, 4].FretPositionY);
        }

        //GuitarString 4 - G

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_0()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 0].FretPositionX);
            Assert.AreEqual(0, guitar[3, 0].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_1()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 1].FretPositionX);
            Assert.AreEqual(1, guitar[3, 1].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_2()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 2].FretPositionX);
            Assert.AreEqual(2, guitar[3, 2].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_3()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 3].FretPositionX);
            Assert.AreEqual(3, guitar[3, 3].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_4()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 4].FretPositionX);
            Assert.AreEqual(4, guitar[3, 4].FretPositionY);
        }

        //GuitarString 5 - B

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_0()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 0].FretPositionX);
            Assert.AreEqual(0, guitar[4, 0].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_1()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 1].FretPositionX);
            Assert.AreEqual(1, guitar[4, 1].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_2()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 2].FretPositionX);
            Assert.AreEqual(2, guitar[4, 2].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_3()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 3].FretPositionX);
            Assert.AreEqual(3, guitar[4, 3].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_4()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 4].FretPositionX);
            Assert.AreEqual(4, guitar[4, 4].FretPositionY);
        }

        //GuitarString 6 - EHigh

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_0()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 0].FretPositionX);
            Assert.AreEqual(0, guitar[5, 0].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_1()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 1].FretPositionX);
            Assert.AreEqual(1, guitar[5, 1].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_2()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 2].FretPositionX);
            Assert.AreEqual(2, guitar[5, 2].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_3()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 3].FretPositionX);
            Assert.AreEqual(3, guitar[5, 3].FretPositionY);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_4()
        {
            Note[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 4].FretPositionX);
            Assert.AreEqual(4, guitar[5, 4].FretPositionY);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }

    
}
