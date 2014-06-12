using Chordial.Tuner.Model;

namespace Chordial.Luthier.Interfaces
{
    public interface ILuthier
    {
        Note[,] BuildInstrument(int strings = 6, int frets = 21);
    }
}
