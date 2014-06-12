using Chordial.Scales;
using Chordial.Scales.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.UnitTests.Scales
{
    [TestFixture]
    public class ChromaticScale_Should
    {
        private ChromaticScale _sut;

        [SetUp]
        public void Init()
        {
            _sut = new ChromaticScale();
        }

        [Test]
        public void GetNotes_ReturnChromaticScaleA_IfEnumIsUndefined()
        {
            const Scale undefinedScale = new Scale();

            List<string> scale = _sut.GetScale(undefinedScale);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_A()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_A()
        {
            List<string> scale = _sut.GetScale(Scale.A);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_A()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_ASharp()
        {
            List<string> scale = _sut.GetScale(Scale.ASharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_ASharp()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_B()
        {
            List<string> scale = _sut.GetScale(Scale.B);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_B()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_C()
        {
            List<string> scale = _sut.GetScale(Scale.C);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_C()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_CSharp()
        {
            List<string> scale = _sut.GetScale(Scale.CSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_CSharp()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_D()
        {
            List<string> scale = _sut.GetScale(Scale.D);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_D()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_DSharp()
        {
            List<string> scale = _sut.GetScale(Scale.DSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_DSharp()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_E()
        {
            List<string> scale = _sut.GetScale(Scale.E);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_E()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_F()
        {
            List<string> scale = _sut.GetScale(Scale.F);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_F()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_FSharp()
        {
            List<string> scale = _sut.GetScale(Scale.FSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_FSharp()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_G()
        {
            List<string> scale = _sut.GetScale(Scale.G);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_G()));
        }

        [Test]
        public void GetNotes_ReturnChromaticScale_GSharp()
        {
            List<string> scale = _sut.GetScale(Scale.GSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_GSharp()));
        }

        [TearDown]
        public void TearDown()
        {
            _sut = new ChromaticScale();
        }
    }
}
