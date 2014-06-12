using Chordial.Scales.Model;
using System.Collections.Generic;

namespace Chordial.Scales.Interfaces
{
    public interface IScaleGenerator
    {
        IEnumerable<string> GetScale(Scale scale);
    }
}
