using Chordial.Luthier.Model;

namespace Chordial.Chords.Interfaces
{
    public interface IChordMapper
    {
        void MapChords(FretSpace[,] fretBoard);

        //look for a suitable pattern
    }
}
