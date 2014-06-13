using Chordial.Luthier;
using Chordial.Luthier.Model;
using Chordial.Scales;
using Chordial.Scales.Interfaces;
using Chordial.Tuner;
using Chordial.Tuner.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.IntegrationTests.Tuner
{
    [TestFixture]
    public class GuitarTuner_Should
    {
        private GuitarLuthier _guitarLuthier;

        private FretSpace[,] _fretBoard;

        private IScaleGenerator _chromaticScale;

        private ITuningMap _standardTuning;

        private GuitarTuner _guitarTuner;

        [SetUp]
        public void Init()
        {
            _guitarLuthier = new GuitarLuthier();
            _fretBoard = _guitarLuthier.BuildInstrument(24, 6);
            _chromaticScale = new ChromaticScale();
            _standardTuning = new StandardTuningMap();
            _guitarTuner = new GuitarTuner(_chromaticScale, _standardTuning);
        }

        [Test]
        public void TuneString_ReturnAllInstancesOfType_FretSpace()
        {
            FretSpace[,] result = _guitarTuner.TuneString(GuitarString.A, _fretBoard);

            List<FretSpace> flat = result.Cast<FretSpace>().ToList();

            CollectionAssert.AllItemsAreInstancesOfType(flat, typeof(FretSpace));
        }

        #region ELow

        [Test]
        public void TuneString_ELowStringTunedCorrectly()
        {
            FretSpace[,] result = _guitarTuner.TuneString(GuitarString.ELow, _fretBoard);
   
            Assert.AreEqual(23, result.GetLength(0));
        }

        #endregion

        #region A

        #endregion

        #region D

        #endregion

        #region G

        #endregion

        #region B

        #endregion

        #region EHigh

        #endregion

        [TearDown]
        public void TearDown()
        {
            _guitarLuthier = null;
            _fretBoard = null;
            _chromaticScale = null;
            _standardTuning = null;
            _guitarTuner = null;
        }
    }
}
