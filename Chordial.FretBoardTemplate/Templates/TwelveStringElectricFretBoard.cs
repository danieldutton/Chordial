using System;
using Chordial.FretBoardTemplate.Model;

namespace Chordial.FretBoardTemplate.Templates
{
    public class TwelveStringElectricFretBoard : AbstractFretBoard
    {
        public TwelveStringElectricFretBoard()
        {
            GuitarType = GuitarType.Electric;
        }

        public override void InitNoteValues()
        {
            throw new NotImplementedException();
        }
    }
}
