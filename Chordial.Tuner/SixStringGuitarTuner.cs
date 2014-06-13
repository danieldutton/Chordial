using Chordial.Luthier.Model;
using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;
using Chordial.Tuner.Interfaces;
using System;
using System.Collections.Generic;

namespace Chordial.Tuner
{
    public class SixStringGuitarTuner : IGuitarTuner
    {
        private readonly IScaleGenerator _scaleGenerator;

        public SixStringGuitarTuner(IScaleGenerator scaleGenerator)
        {
            _scaleGenerator = scaleGenerator;
        }

        public void TuneString(GuitarString guitarString, FretSpace[,] fretboard)
        {
            //get the collection of notes we need to iterate over
            IEnumerable<string> result = _scaleGenerator.GetScale(Scale.A);
            string[] _notes = Enum.GetNames(typeof(Scale));

            //set the iterate counter to the length of the fretboard
            const int fretLength = 24;

            int counter = 0;

            //for every fret space
            for (int i = 0; i < fretLength; i++)
            {
                //increment the fret space we are on
                counter++;

                //exit the loop if frets exceeded
                if (counter == fretLength)
                    break;

                //if we have ran out of notes
                if (i == _notes.Length)
                {
                    //then run through the notes again
                    i = 0;
                }
                int f = (int) guitarString;
                //write out the note for that fret
                fretboard[f, i].Note = _notes[i];
            }    
        }      
    }
}
