using Chordial.FretBoardTemplate.Model;

namespace Chordial.FretBoardTemplate.Templates
{
    public class Acoustic6StringFretBoard : AbstractFretBoard
    {
        public Acoustic6StringFretBoard()
        {
            GuitarType = GuitarType.Acoustic;
        }

        public override void InitNoteValues()
        {
            for (int i = 0; i < FretBoard.GetLongLength(0); i++)
            {
                for (int j = 0; j < FretBoard.GetLongLength(1); j++)
                {

                }
            }
        }
    }
}
