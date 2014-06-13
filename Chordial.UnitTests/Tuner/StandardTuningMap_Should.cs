using Chordial.Luthier.Model;
using Chordial.Scales.Model;
using Chordial.Tuner;
using Chordial.Tuner.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.UnitTests.Tuner
{
    [TestFixture]
    public class StandardTuningMap_Should
    {
        private ITuningMap _sut;

        [SetUp]
        public void Init()
        {
            _sut = new StandardTuningMap();
        }

        [Test]
        public void GetMap_ReturnAMapWithSixElements()
        {
            Dictionary<GuitarString, Scale> result = _sut.GetMap();

            Assert.AreEqual(6, result.Count);
        }

        [Test]
        public void GetMap_ReturnCorrectSequenceOfKeys()
        {
            List<GuitarString> result = _sut.GetMap().Keys.ToList();

            Assert.IsTrue(result.SequenceEqual(Mother.ExpectedKeySequence_StandardTuning()));
        }

        [Test]
        public void GetMap_ReturnCorrectSequenceOfValues()
        {
            List<Scale> result = _sut.GetMap().Values.ToList();

            Assert.IsTrue(result.SequenceEqual(Mother.ExpectedValueSequence_StandardTuning()));
        }

        [Test]
        public void GetMap_ReturnTheCorrectType()
        {
            Dictionary<GuitarString, Scale> result = _sut.GetMap();

            Assert.IsInstanceOf<Dictionary<GuitarString, Scale>>(result);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
