using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.Scales
{
    public class ChromaticScale : IScaleGenerator
    {
        public List<string> GetScale(Scale scale)
        {
            if (!Enum.IsDefined(typeof(Scale), scale))
                scale = Scale.A;

            List<string> values = Enum.GetNames(typeof(Scale)).ToList();

            var orderedValues = new List<string>();
            int counter = 0;

            for (int i = (int)scale; i <= values.Count; i++)
            {
                counter++;

                if (i == values.Count)
                    i = 0;

                orderedValues.Add(values[i]);

                if (counter == values.Count)
                    break;
            }
            return orderedValues;
        }
    }
}
