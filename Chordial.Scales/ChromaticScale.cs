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

            List<string> notes = Enum.GetNames(typeof(Scale)).ToList();

            var orderedValues = new List<string>();
            
            int counter = 0;

            for (int i = (int)scale; i <= notes.Count; i++)
            {
                counter++;

                if (i == notes.Count)
                    i = 0;

                orderedValues.Add(notes[i]);

                if (counter == notes.Count)
                    break;
            }
            return orderedValues;
        }
    }
}
