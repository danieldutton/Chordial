using Chordial.FretboardBuilder.Model;
using System;

namespace Chordial.Sandbox
{
    public class Program
    {
        public static void Main()
        {
            //get the collection of notes we need to iterate over
            string[] noteName = Enum.GetNames(typeof(NoteName));

            //init the start index for the string start note

            //set the iterate counter to the length of the fretboard
            const int fretLength = 24;

            int counter = 0;

            //for every fret space
            for (int i = 0; i < fretLength; i++)
            {
                counter++;

                if (counter == fretLength)
                    break;

                //if we have ran out of notes
                if (i == noteName.Length)
                {
                    //then start again iterating from the collection start
                    i = 0;
                }

                //write out the note for that fret
                Console.WriteLine(noteName[i]);  
            }               
            Console.ReadKey();
        }
    }
}
