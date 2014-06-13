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

        //is scale naming consistent with other classes
        [Test]
        public void GetScale_ReturnChromaticScaleA_IfEnumIsUndefined()
        {
            const Scale undefinedScale = new Scale();

            IEnumerable<string> scale = _sut.GetScale(undefinedScale);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_A()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_A()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.A);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_A()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_ASharp()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.ASharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_ASharp()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_B()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.B);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_B()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_C()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.C);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_C()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_CSharp()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.CSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_CSharp()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_D()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.D);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_D()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_DSharp()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.DSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_DSharp()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_E()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.E);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_E()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_F()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.F);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_F()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_FSharp()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.FSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_FSharp()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_G()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.G);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_G()));
        }

        [Test]
        public void GetScale_ReturnChromaticScale_GSharp()
        {
            IEnumerable<string> scale = _sut.GetScale(Scale.GSharp);

            Assert.IsTrue(scale.SequenceEqual(Mother.ChromaticScale_GSharp()));
        }

        [TearDown]
        public void TearDown()
        {
            _sut = new ChromaticScale();
        }
    }
}
