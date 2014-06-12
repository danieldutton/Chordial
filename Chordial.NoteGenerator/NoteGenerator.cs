using System;
using System.Collections.Generic;
using Chordial.FretboardBuilder.Model;
using Chordial.NoteBuilder.Interfaces;
using Chordial.Scales.Model;

namespace Chordial.NoteBuilder
{
    public class NoteGenerator : INoteGenerator
    {
        private IList<string> _notes;

        public NoteGenerator(IList<string> notes)
        {
            _notes = notes;
        }

        public void GenerateNotes(GuitarString startString, Note[,] fretboard)
        {
            //get the collection of notes we need to iterate over
            _notes = Enum.GetNames(typeof(Scale));

            //init the start index for the string start note

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
                if (i == _notes.Count)
                {
                    //then run through the notes again
                    i = 0;
                }
                int f = (int) startString;
                //write out the note for that fret
                fretboard[f, i].Scale = _notes[i];
                Console.WriteLine(_notes[i]);
            }    
        }      
    }
}
