using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.Scales
{
    public class MinorScale : IScaleGenerator
    {
        //scales will never change can we hard code them say in xml

        //example AMinor
        //A, B, C, D, E, F, G         //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example A#Minor
        //A#, C, C#, D#, F, F# G#     //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example BMinor
        //B, C#, D, E, F#, G, A       //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example CMinor
        //C, D, D#, F, G, G#, A#      //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example C#Minor
        //C#, D#, E, F#, G#, A, B     //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example DMinor
        //D, E, F, G, A, A#, C        //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example D#Minor
        //D#, F, F#, G#, A#, B, C#    //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example EMinor
        //E, F#, G, A, B, C, D        //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example FMinor
        //F, G, G#, A#, C, C#, D#     //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example F#Minor
        //F#, G#, A, B, C#, D, E      //Steps - Whole/Half/Whole/Whole/Half/Whole

        //example GMinor
        //G, A, A#, C, D, D#, F       //Steps - Whole/Half/Whole/Half/Whole/Whole

        //example G#Minor
        //G#, A#, B, C#, D#, E, F#    //Steps - Whole/Half/Whole/Whole/Half/Whole

        public IEnumerable<string> GetScale(Scale scale)
        {
            if (!Enum.IsDefined(typeof(Scale), scale))
                scale = Scale.A;

            List<string> scaleNotes = Enum.GetNames(typeof(Scale)).ToList();

            var chromaticScale = new List<string>();

            int counter = 0;

            for (int i = (int)scale; i <= scaleNotes.Count; i++)
            {
                //amend this algorithm for minor scale
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
