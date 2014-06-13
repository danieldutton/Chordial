using Chordial.Luthier.Model;
using Chordial.Scales.Interfaces;
using Chordial.Tuner;
using Chordial.Tuner.Interfaces;
using Moq;
using NUnit.Framework;
using System;

namespace Chordial.UnitTests.Tuner
{
    [TestFixture]
    public class GuitarTuner_Should
    {
        private Mock<IScaleGenerator> _fakeScaleGenerator;

        private Mock<ITuningMap> _fakeTuningMap;

        private GuitarTuner _sut;

        [SetUp]
        public void Init()
        {
            _fakeScaleGenerator = new Mock<IScaleGenerator>();
            _fakeTuningMap = new Mock<ITuningMap>();
            _sut = new GuitarTuner(_fakeScaleGenerator.Object, _fakeTuningMap.Object);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TuneString_ThrowArgumentNullException_IfFretboardIsNull()
        {
            _sut.TuneString(GuitarString.A, null);
        }

        //enum test here

        [Test]
        public void TuneString_CallGetMap_ExactlyOnce()
        {
            var fretboardStub = new FretSpace[0,0];
            
            _fakeTuningMap.Setup(x => x.GetMap());

            _sut.TuneString(GuitarString.A, fretboardStub);

            _fakeTuningMap.Verify(x => x.GetMap(), Times.Exactly(2));
        }

        [Test]
        public void TuneString_CallGetScaleExactlyOnce()
        {
            
        }

        [Test]
        public void TuneString_CallGetScaleExactlyOnce_WithCorrectData()
        {
            
        }

        [Test]
        public void TuneString_TuneELow_WithCorrectNoteSequence()
        {
            
        }

        [Test]
        public void TuneString_TuneA_WithCorrectNoteSequence()
        {

        }

        [Test]
        public void TuneString_TuneD_WithCorrectNoteSequence()
        {

        }

        [Test]
        public void TuneString_TuneG_WithCorrectNoteSequence()
        {

        }

        [Test]
        public void TuneString_TuneB_WithCorrectNoteSequence()
        {

        }

        [Test]
        public void TuneString_TuneEHigh_WithCorrectNoteSequence()
        {

        }
    }
}
