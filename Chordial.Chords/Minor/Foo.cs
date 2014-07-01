using System.Collections.Generic;
using System.Linq;
using Chordial.Chords.Interfaces;
using Chordial.Luthier.Model;
using Chordial.Scales;
using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;

namespace Chordial.Chords.Minor
{
    public class Foo : IChordMapper 
    {
        public void MapChords(FretSpace[,] fretBoard)
        {
            //lets flatten the fretboard so we can do it all strings in one go
            List<FretSpace> flatFretBoard = fretBoard.Cast<FretSpace>().ToList();

            //lets get the chromatic scale we need to work with
            IScaleGenerator scaleGen = new ChromaticScale();
            IEnumerable<string> chromNotes = scaleGen.GetScale(Scale.A);

        }
    }
}
