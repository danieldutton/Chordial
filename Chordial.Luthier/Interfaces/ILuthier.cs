using Chordial.Luthier.Model;

namespace Chordial.Luthier.Interfaces
{
    public interface ILuthier
    {
        FretSpace[,] BuildInstrument(int strings = 6, int frets = 21);
    }
}
