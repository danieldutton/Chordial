using NUnit.Framework;

namespace Chordial.UnitTests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void EightColoumnsOnFretBoard()
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
        public void SixRowsOnFretBoard()
        {
            var aMinorBuilder = new AminorBuilder();
            int[,] grid = aMinorBuilder.GetAMinorChords();

            Assert.AreEqual(5, grid.GetLongLength(1));
        }
    }


    //FretBoard Structure
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
    }
}

    public enum NoteStatus
    {
        Open, 
        Pressed, 
        Mute,
    }
