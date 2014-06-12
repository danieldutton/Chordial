using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;
using Chordial.Tuner.Interfaces;
using Chordial.Tuner.Model;
using System;

namespace Chordial.Tuner
{
    //we are just tuning a string one at a time
    public class SixStringGuitarTuner : IGuitarTuner
    {
        private readonly IScaleGenerator _scaleGenerator;

        public SixStringGuitarTuner(IScaleGenerator scaleGenerator)
        {
            _scaleGenerator = scaleGenerator;
        }

        public void TuneString(GuitarString guitarString, Note[,] fretboard)
        {
            //get the collection of notes we need to iterate over
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
                fretboard[f, i].Scale = _notes[i];
            }    
        }      
    }
}
