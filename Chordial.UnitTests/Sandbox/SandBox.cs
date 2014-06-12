using NUnit.Framework;
using System;

namespace Chordial.UnitTests
{

    //Fretboard Structure
    /*
          0  1  2  3  4  5  6  7  8
     E(0)[ ][ ][ ][ ][ ][*][ ][ ][ ]
     B(1)[*][ ][ ][ ][ ][*][ ][ ][ ]
     G(2)[ ][*][ ][ ][ ][*][ ][ ][ ]
     D(3)[ ][*][ ][ ][ ][*][ ][*][ ]
     A(4)[ ][ ][ ][ ][ ][*][ ][*][ ]
     E(5)[ ][ ][ ][ ][ ][*][ ][ ][ ]
     
     */
    [TestFixture]
    public class SandBox
    {
        [Test]
        public void GetNoteFreeFretBoard_EightColoumnsOnFretBoard()
        {
            //0 for open string, 1 for note press

            var aMinorBuilder = new AminorBuilder();
            int[,] grid = aMinorBuilder.GetAMinorChords();

            //how long do we want the complete fretboard?
            Assert.AreEqual(8, grid.GetLongLength(0));

            //how do we represent mute strings
            //value 2 maybe
        }

        [Test]
        public void GetNoteFreeFretBoard_SixRowsOnFretBoard()
        {
            var aMinorBuilder = new AminorBuilder();
            int[,] grid = aMinorBuilder.GetAMinorChords();

            Assert.AreEqual(5, grid.GetLongLength(1));
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
}

public class AminorBuilder
{
    public int[,] GetAMinorChords()
    {
        var aMinor1 = new int[8, 5];

        //should chords be separated for separate display or placed on 
        //one fretboard.  Seperate Method maybe.  
        aMinor1[0, 1] = 1;
        aMinor1[1, 2] = 1;
        aMinor1[1, 3] = 1;

        aMinor1[5, 0] = 1;
        aMinor1[5, 1] = 1;
        aMinor1[5, 2] = 1;
        aMinor1[5, 3] = 1;
        aMinor1[7, 3] = 1;
        aMinor1[7, 4] = 1;

        return aMinor1;

        //do we need multiple fretboard lengths
        //20 frets on average for an acoustic

        //24 to 26 for an electric
    }
}

public interface INoteBuilder
{
    void BuildNotes();
}

public class NoteBuilder : INoteBuilder
{
    public void BuildNotes()
    {
        throw new NotImplementedException();
    }
}

public enum NoteStatus
{
    Open,
    Pressed,
    Mute,
}

/*
 Need to check the theory behind note naming i.e should it be a sharp or a flat etc
 * Do we need to represent both sharp and flat at the same time to avoid confusion
 */

/*
 Further ideas
 * 
 * Can note store wav file we can play and listen to.  Can we record the chord and listen to that also
 
 */





