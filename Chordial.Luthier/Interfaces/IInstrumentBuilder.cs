using Chordial.Tuner.Model;

namespace Chordial.Luthier.Interfaces
{
    public interface IInstrumentBuilder
    {
        Note[,] GetInstrument(int strings = 6, int frets = 21);
    }
}
