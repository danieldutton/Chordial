using System;
using Chordial.FretBoardTemplate.Model;

namespace Chordial.FretBoardTemplate.Templates
{
    public class Electric_6_StringFretBoard : AbstractFretBoard
    {
        public Electric_6_StringFretBoard()
        {
            GuitarType = GuitarType.Electric;;
        }

        public override void InitNoteValues()
        {
            Console.WriteLine("Working");
        }
    }
}
