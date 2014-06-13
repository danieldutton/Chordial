using Chordial.Luthier.Model;

namespace Chordial.Tuner.Interfaces
{
    public interface IGuitarTuner
    {
        void TuneString(GuitarString stringToTune, FretSpace[,] fretboard);
    }
}
