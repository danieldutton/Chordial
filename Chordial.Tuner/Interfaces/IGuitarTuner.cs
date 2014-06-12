using Chordial.Tuner.Model;

namespace Chordial.Tuner.Interfaces
{
    public interface IGuitarTuner
    {
        void TuneString(GuitarString guitarString, Note[,] fretboard);
    }
}
