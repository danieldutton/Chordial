using Chordial.Luthier.Interfaces;
using Chordial.Tuner.Model;
using System;

namespace Chordial.Luthier
{
    public class GuitarLuthier : ILuthier
    {
        public Note[,] BuildInstrument(int strings = 6, int frets = 24)
        {
            if (strings < 1) throw new ArgumentOutOfRangeException("strings");
            if (frets < 1) throw new ArgumentOutOfRangeException("frets");

            var notes = new Note[strings, frets];

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    notes[i, j] = new Note
                    {
                        FretPositionX = i,
                        FretPositionY = j,
                    };
                }
            }
            return notes;
        }
    }
}