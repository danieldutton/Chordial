using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.Scales
{
    public class ChromaticScale : IScaleGenerator
    {
        public IEnumerable<string> GetScale(Scale scale)
        {
            if (!Enum.IsDefined(typeof(Scale), scale))
                scale = Scale.A;

            List<string> scaleNotes = Enum.GetNames(typeof(Scale)).ToList();

            var chromaticScale = new List<string>();
            
            int counter = 0;

            for (int i = (int)scale; i <= scaleNotes.Count; i++)
            {
                counter++;

                if (i == scaleNotes.Count)
                    i = 0;

                chromaticScale.Add(scaleNotes[i]);

                if (counter == scaleNotes.Count)
                    break;
            }
            return chromaticScale;
        }
    }
}
