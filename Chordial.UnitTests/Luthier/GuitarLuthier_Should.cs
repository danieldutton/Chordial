using Chordial.Luthier;
using Chordial.Luthier.Model;
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
            FretSpace[,] guitar = _sut.BuildInstrument();

            Assert.AreEqual(6, guitar.GetLength(0));
        }

        [Test]
        public void BuildInstrument_WithTwentyFourFretSpacesByDefault()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            Assert.AreEqual(24, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_WithSixStrings()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(6);

            Assert.AreEqual(6, guitar.GetLength(0));
        }

        [Test]
        public void BuildInstrument_WithTwentyFretSpaces()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 10);

            Assert.AreEqual(10, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_WithTwentyFourFretSpaces()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 10);

            Assert.AreEqual(10, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_AllFretSpacesAreOfType_Note()
        {
            FretSpace[] guitar = _sut.BuildInstrument(strings:6, frets: 10)
                .Cast<FretSpace>()
                .ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(guitar, typeof(FretSpace));
        }

        //GuitarString 1 - ELow

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_0()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 0].XPos);
            Assert.AreEqual(0, guitar[0, 0].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_1()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 1].XPos);
            Assert.AreEqual(1, guitar[0, 1].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_2()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 2].XPos);
            Assert.AreEqual(2, guitar[0, 2].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_3()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 3].XPos);
            Assert.AreEqual(3, guitar[0, 3].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_0_4()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(0, guitar[0, 4].XPos);
            Assert.AreEqual(4, guitar[0, 4].YPos);
        }

        //GuitarString 2 - A

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_0()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 0].XPos);
            Assert.AreEqual(0, guitar[1, 0].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_1()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 1].XPos);
            Assert.AreEqual(1, guitar[1, 1].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_2()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 2].XPos);
            Assert.AreEqual(2, guitar[1, 2].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_3()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 3].XPos);
            Assert.AreEqual(3, guitar[1, 3].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_1_4()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(1, guitar[1, 4].XPos);
            Assert.AreEqual(4, guitar[1, 4].YPos);
        }

        //GuitarString 3 - D

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_0()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 0].XPos);
            Assert.AreEqual(0, guitar[2, 0].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_1()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 1].XPos);
            Assert.AreEqual(1, guitar[2, 1].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_2()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 2].XPos);
            Assert.AreEqual(2, guitar[2, 2].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_3()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 3].XPos);
            Assert.AreEqual(3, guitar[2, 3].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_2_4()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(2, guitar[2, 4].XPos);
            Assert.AreEqual(4, guitar[2, 4].YPos);
        }

        //GuitarString 4 - G

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_0()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 0].XPos);
            Assert.AreEqual(0, guitar[3, 0].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_1()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 1].XPos);
            Assert.AreEqual(1, guitar[3, 1].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_2()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 2].XPos);
            Assert.AreEqual(2, guitar[3, 2].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_3()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 3].XPos);
            Assert.AreEqual(3, guitar[3, 3].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_3_4()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(3, guitar[3, 4].XPos);
            Assert.AreEqual(4, guitar[3, 4].YPos);
        }

        //GuitarString 5 - B

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_0()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 0].XPos);
            Assert.AreEqual(0, guitar[4, 0].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_1()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 1].XPos);
            Assert.AreEqual(1, guitar[4, 1].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_2()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 2].XPos);
            Assert.AreEqual(2, guitar[4, 2].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_3()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 3].XPos);
            Assert.AreEqual(3, guitar[4, 3].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_4_4()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(4, guitar[4, 4].XPos);
            Assert.AreEqual(4, guitar[4, 4].YPos);
        }

        //GuitarString 6 - EHigh

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_0()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 0].XPos);
            Assert.AreEqual(0, guitar[5, 0].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_1()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 1].XPos);
            Assert.AreEqual(1, guitar[5, 1].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_2()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 2].XPos);
            Assert.AreEqual(2, guitar[5, 2].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_3()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 3].XPos);
            Assert.AreEqual(3, guitar[5, 3].YPos);
        }

        [Test]
        public void BuildInstrument_InitFretPositionXYProperties_5_4()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 5);

            Assert.AreEqual(5, guitar[5, 4].XPos);
            Assert.AreEqual(4, guitar[5, 4].YPos);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }

    
}
