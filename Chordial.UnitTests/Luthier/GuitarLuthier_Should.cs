using Chordial.Luthier;
using Chordial.Luthier.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 20);

            Assert.AreEqual(20, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_WithTwentyFourFretSpaces()
        {
            FretSpace[,] guitar = _sut.BuildInstrument(strings: 6, frets: 24);

            Assert.AreEqual(24, guitar.GetLength(1));
        }

        [Test]
        public void BuildInstrument_AllFretSpacesAreOfType_Note()
        {
            FretSpace[] guitar = _sut.BuildInstrument(strings:6, frets: 10)
                .Cast<FretSpace>()
                .ToArray();

            CollectionAssert.AllItemsAreInstancesOfType(guitar, typeof(FretSpace));
        }

        [Test]
        public void Buildinstrument_InitXPosPropertiesCorrectly_ELow()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> xPosList = guitar.Cast<FretSpace>()
                .Take(24)
                .Select(x => x.XPos)
                .ToList(); 

            Assert.IsTrue(xPosList.SequenceEqual(Mother.ExpectedXPosSequence()));
        }

        [Test]
        public void BuildInstrument_InitYPosPropertiesCorrectly_ELow()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> yPosList = guitar.Cast<FretSpace>()
                .Take(24)
                .Select(x => x.YPos)
                .ToList();

            Assert.IsTrue(yPosList.All(x => x == 0));
        }

        [Test]
        public void Buildinstrument_InitXPosPropertiesCorrectly_A()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> xPosList = guitar.Cast<FretSpace>()
                .Skip(24)
                .Take(24)
                .Select(x => x.XPos)
                .ToList();

            Assert.IsTrue(xPosList.SequenceEqual(Mother.ExpectedXPosSequence()));
        }

        [Test]
        public void BuildInstrument_InitYPosPropertiesCorrectly_A()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> xPosList = guitar.Cast<FretSpace>()
                .Skip(24)
                .Take(24)
                .Select(x => x.YPos)
                .ToList();

            Assert.IsTrue(xPosList.All(x => x == 1));
        }

        [Test]
        public void Buildinstrument_InitXPosPropertiesCorrectly_D()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> xPosList = guitar.Cast<FretSpace>()
                .Skip(48)
                .Take(24)
                .Select(x => x.XPos)
                .ToList();

            Assert.IsTrue(xPosList.SequenceEqual(Mother.ExpectedXPosSequence()));
        }

        [Test]
        public void BuildInstrument_InitYPosPropertiesCorrectly_D()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> elowYPosList = guitar.Cast<FretSpace>()
                .Skip(48)
                .Take(24)
                .Select(x => x.YPos)
                .ToList();

            Assert.IsTrue(elowYPosList.All(x => x == 2));
        }

        [Test]
        public void Buildinstrument_InitXPosPropertiesCorrectly_G()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> xPosList = guitar.Cast<FretSpace>()
                .Skip(72)
                .Take(24)
                .Select(x => x.XPos)
                .ToList();

            Assert.IsTrue(xPosList.SequenceEqual(Mother.ExpectedXPosSequence()));
        }

        [Test]
        public void BuildInstrument_InitYPosPropertiesCorrectly_G()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> elowYPosList = guitar.Cast<FretSpace>()
                .Skip(72)
                .Take(24)
                .Select(x => x.YPos)
                .ToList();

            Assert.IsTrue(elowYPosList.All(x => x == 3));
        }

        [Test]
        public void Buildinstrument_InitXPosPropertiesCorrectly_B()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> xPosList = guitar.Cast<FretSpace>()
                .Skip(96)
                .Take(24)
                .Select(x => x.XPos)
                .ToList();

            Assert.IsTrue(xPosList.SequenceEqual(Mother.ExpectedXPosSequence()));
        }

        [Test]
        public void BuildInstrument_InitYPosPropertiesCorrectly_B()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> elowYPosList = guitar.Cast<FretSpace>()
                .Skip(96)
                .Take(24)
                .Select(x => x.YPos)
                .ToList();

            Assert.IsTrue(elowYPosList.All(x => x == 4));
        }

        [Test]
        public void Buildinstrument_InitXPosPropertiesCorrectly_EHigh()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> xPosList = guitar.Cast<FretSpace>()
                .Skip(120)
                .Take(24)
                .Select(x => x.XPos)
                .ToList();

            Assert.IsTrue(xPosList.SequenceEqual(Mother.ExpectedXPosSequence()));
        }

        [Test]
        public void BuildInstrument_InitYPosPropertiesCorrectly_EHigh()
        {
            FretSpace[,] guitar = _sut.BuildInstrument();

            List<int> elowYPosList = guitar.Cast<FretSpace>()
                .Skip(120)
                .Take(24)
                .Select(x => x.YPos)
                .ToList();

            Assert.IsTrue(elowYPosList.All(x => x == 5));
        }
        
        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }   
}
