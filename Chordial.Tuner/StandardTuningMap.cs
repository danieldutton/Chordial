using Chordial.Luthier.Model;
using Chordial.Scales.Model;
using Chordial.Tuner.Interfaces;
using System.Collections.Generic;

namespace Chordial.Tuner
{
    public class StandardTuningMap : ITuningMap
    {
        public Dictionary<GuitarString, Scale> GetMap()
        {
            var stringToScaleMap = new Dictionary<GuitarString, Scale>
            {
                {GuitarString.ELow, Scale.E},
                {GuitarString.A, Scale.A},
                {GuitarString.D, Scale.D},
                {GuitarString.G, Scale.G},
                {GuitarString.B, Scale.B},
                {GuitarString.EHigh, Scale.E},
            };

            return stringToScaleMap;
        }
    }
}
