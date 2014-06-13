using Chordial.Luthier.Model;
using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.Tuner
{
    public class GuitarTuner 
    {
        private readonly IScaleGenerator _scaleGenerator;

        public GuitarTuner(IScaleGenerator scaleGenerator)
        {
            _scaleGenerator = scaleGenerator;
        }

        public void TuneString(GuitarString stringToTune, FretSpace[,] fretboard)
        {
            List<string> notes = null;

            if (stringToTune == GuitarString.ELow)
            {
                notes = _scaleGenerator.GetScale(Scale.E).ToList();
            }
            if (stringToTune == GuitarString.A)
            {
                notes = _scaleGenerator.GetScale(Scale.A).ToList();
            }
            if (stringToTune == GuitarString.D)
            {
                notes = _scaleGenerator.GetScale(Scale.D).ToList();
            }
            if (stringToTune == GuitarString.G)
            {
                notes = _scaleGenerator.GetScale(Scale.G).ToList();
            }
            if (stringToTune == GuitarString.B)
            {
                notes = _scaleGenerator.GetScale(Scale.B).ToList();
            }
            if (stringToTune == GuitarString.EHigh)
            {
                notes = _scaleGenerator.GetScale(Scale.E).ToList();
            }
            
            int counter = 0;

            //for every fret space
            for (int i = 0; i < fretboard.GetLength(0); i++)
            {
                //increment the fret space we are on
                counter++;

                //exit the loop if frets exceeded
                if (counter == fretboard.GetLength(0))
                    break;

                //if we have ran out of notes
                if (i == notes.Count())
                {
                    //then run through the notes again
                    i = 0;
                }
                int f = (int) stringToTune;
                //write out the note for that fret
                fretboard[f, i].Note = notes[i];
            }    
        }      
    }
}
