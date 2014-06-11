using Chordial.FretboardBuilder.Model;

namespace Chordial.FretboardBuilder.Interfaces
{
    public interface IFretBoardGenerator
    {
        Note[,] GetFretBoard(int strings = 6, int frets = 21);
    }
}
