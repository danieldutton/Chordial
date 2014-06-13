using System.Collections.Generic;
using System.Linq;

namespace Chordial.UnitTests
{
    public static class Mother
    {
        public static List<string> GetOpenNotes()
        {
            var notes = new List<string>
            {
                "ELow", "A", "D", "G", "B", "EHigh",
            };

            return notes;
        }

        public static List<string> ChromaticScale_A()
        {
            var scaleA = new List<string>
            {
                "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp",
            };

            return scaleA;
        }

        public static List<string> ChromaticScale_ASharp()
        {
            var scaleASharp = new List<string>
            {
                "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp", "A",
            };

            return scaleASharp;
        }

        public static List<string> ChromaticScale_B()
        {
            var scaleB = new List<string>
            {
                "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp","A", "ASharp", 
            };

            return scaleB;
        }

        public static List<string> ChromaticScale_C()
        {
            var scaleC = new List<string>
            {
                "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp","A", "ASharp", "B", 
            };

            return scaleC;
        }

        public static List<string> ChromaticScale_CSharp()
        {
            var scaleCSharp = new List<string>
            {
                "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp","A", "ASharp", "B", "C",
            };

            return scaleCSharp;
        }

        public static List<string> ChromaticScale_D()
        {
            var scaleD = new List<string>
            {
                "D", "DSharp", "E", "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp",
            };

            return scaleD;
        }

        public static List<string> ChromaticScale_DSharp()
        {
            var scaleDSharp = new List<string>
            {
                "DSharp", "E", "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", 
            };

            return scaleDSharp;
        }

        public static List<string> ChromaticScale_E()
        {
            var scaleE = new List<string>
            {
                "E", "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", 
            };

            return scaleE;
        }

        public static List<string> ChromaticScale_F()
        {
            var scaleF = new List<string>
            {
                "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", 
            };

            return scaleF;
        }

        public static List<string> ChromaticScale_FSharp()
        {
            var scaleFSharp = new List<string>
            {
                "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", 
            };

            return scaleFSharp;
        }

        public static List<string> ChromaticScale_G()
        {
            var scaleG = new List<string>
            {
                "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", 
            };

            return scaleG;
        }

        public static List<string> ChromaticScale_GSharp()
        {
            var scaleGSharp = new List<string>
            {
                "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", 
            };

            return scaleGSharp;
        }

        //lets use this to simplify luther tests
        public static IEnumerable<int> FretBoardXPosSequence()
        {
            IEnumerable<int> range = Enumerable.Range(0, 24);

            return range;
        } 
    }
}
