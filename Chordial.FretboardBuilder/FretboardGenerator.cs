﻿using System;

namespace Chordial.FretboardBuilder
{
    //we need to take into account the open notes.  The first column of the array should be used for this purpose
    //start drawing the actual grid from one onwards

    /*
     * The pitch of each consecutive fret is defined at a half-step interval on the chromatic scale. 
     * Standard classical guitars have 19 frets and electric guitars between 21 to 24 frets, although guitars 
     * have been made with as many as 27 frets
     * */

    public class FretboardGenerator
    {
        private Note[,] _notes; //shouldnt this really be local

        public Note[,] GetFretBoard(int strings = 6, int frets = 21)
        {
            if (strings < 1) throw new ArgumentOutOfRangeException("strings");
            if (frets < 1) throw new ArgumentOutOfRangeException("frets");

            _notes = new Note[strings, frets];

            for (int i = 0; i < _notes.GetLength(0); i++)
            {
                for (int j = 0; j < _notes.GetLength(1); j++)
                {
                    _notes[i, j] = new Note
                    {
                        FretPositionX = i,
                        FretPositionY = j,
                    };
                }
            }
            return _notes;
        }
    }
}

//AbstractFretBoard Structure
/*
      0  1  2  3  4  5  6  7  8
 E(0)[ ][ ][ ][ ][ ][*][ ][ ][ ]
 B(1)[*][ ][ ][ ][ ][*][ ][ ][ ]
 G(2)[ ][*][ ][ ][ ][*][ ][ ][ ]
 D(3)[ ][*][ ][ ][ ][*][ ][*][ ]
 A(4)[ ][ ][ ][ ][ ][*][ ][*][ ]
 E(5)[ ][ ][ ][ ][ ][*][ ][ ][ ]
     
 */