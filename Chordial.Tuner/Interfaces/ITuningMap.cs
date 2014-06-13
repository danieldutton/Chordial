using Chordial.Luthier.Model;
using Chordial.Scales.Model;
using System.Collections.Generic;

namespace Chordial.Tuner.Interfaces
{
    public interface ITuningMap
    {
        Dictionary<GuitarString, Scale> GetMap();
    }
}
