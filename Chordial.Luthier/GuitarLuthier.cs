using Chordial.Luthier.Interfaces;
using Chordial.Luthier.Model;
using System;

namespace Chordial.Luthier
{
    public class GuitarLuthier : ILuthier
    {
        public FretSpace[,] BuildInstrument(int strings = 6, int frets = 24)
        {
            if (strings < 1) throw new ArgumentOutOfRangeException("strings");
            if (frets < 1) throw new ArgumentOutOfRangeException("frets");

            var notes = new FretSpace[strings, frets];

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    notes[i, j] = new FretSpace
                    {
                        XPos = i,
                        YPos = j,
                    };
                }
            }
            return notes;
        }
    }
}