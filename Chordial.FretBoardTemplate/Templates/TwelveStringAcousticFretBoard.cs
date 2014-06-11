using System;
using Chordial.FretBoardTemplate.Model;

namespace Chordial.FretBoardTemplate.Templates
{
    public class TwelveStringAcousticFretBoard : AbstractFretBoard
    {
        public TwelveStringAcousticFretBoard()
        {
            GuitarType = GuitarType.Acoustic;
        }

        public override void InitNoteValues()
        {
            throw new NotImplementedException();
        }
    }
}
