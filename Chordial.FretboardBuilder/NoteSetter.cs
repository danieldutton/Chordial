using Chordial.FretboardBuilder.Model;
using System;

namespace Chordial.FretboardBuilder
{
    //we might need different note setting strategies depening on if we are down-tuning or not
    //if we use separate strategies we also wont need to worry as much about passing in config parameters
    //as they can be hard coded
    //we could also do the whole fretboard in one go rather than a string at a time
    //note might also need to inherit from panel and we do all the painting from there
    //add resources for each note.. image
    public class NoteSetter
    {
        public Note[,] SetNotes(int stringNo, Note[,] fretBoard)
        {
            //get the collection of notes we gathered for that string
            string[] notes = Enum.GetNames(typeof(NoteName));

            //start iterating on the start string 0 index
            for (int i = 0; i < fretBoard.Length; i++)
            {
                //set the note value for each fret space and loop where appropriate   
            }

            int noteCount = 0;
            for (int i = 0; i < fretBoard.GetLength(1); i++)
            {
                //if (noteCount == 7)
                //    noteCount = 0;

                fretBoard[stringNo, i].NoteName = new NoteName();

                noteCount++;
            }

            return fretBoard;
        }
    }
}
