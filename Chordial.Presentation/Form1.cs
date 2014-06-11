using System.Windows.Forms;
using Chordial.FretBoardTemplate.Model;

namespace Chordial.Presentation
{
    public partial class Form1 : Form
    {
        Note[,] notes = new Note[6, 10];

        public Form1()
        {
            InitializeComponent();            
        }

        public void BuildGrid(Guitar fretBoardSixe)
        {
            notes = new Note[6, 10];

            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for (int j = 0; j < notes.GetLength(1); j++)
                {
                    notes[i, j] = new Note
                    {
                        FretPositionX = i,
                        FretPositionY = j,
                    };
                }
            }
        }
    }

    public enum Guitar
    {
        Strings = 6,
        Frets = 20,
    }
}
