using Chordial.FretBoardTemplate.Model;

namespace Chordial.FretBoardTemplate
{
    public abstract class AbstractFretBoard
    {
        protected GuitarType GuitarType;
        
        private const int StringCount = 6;

        protected Note[,] FretBoard;


        public Note[,] GetFretBoard()
        {
            GetNoteFreeFretBoard();
            InitFretBoardNotes();
            InitNoteCoOrdinates();
            InitNoteValues();

            return FretBoard;
        }

        public virtual void GetNoteFreeFretBoard()
        {
            FretBoard = new Note[(int)GuitarType, StringCount];
        }

        public virtual void InitFretBoardNotes()
        {
            for (int i = 0; i < FretBoard.GetLongLength(0); i++)
            {
                for (int j = 0; j < StringCount; j++)
                {
                    FretBoard[i, j] = new Note();
                }
            }
        }

        public virtual void InitNoteCoOrdinates()
        {
            for (int i = 0; i < FretBoard.GetLongLength(0); i++)
            {
                for (int j = 0; j < StringCount; j++)
                {
                    FretBoard[i, j].FretPositionX = i;
                    FretBoard[i, j].FretPositionY = j;
                }
            }
        }

        public abstract void InitNoteValues();       
    }
}
