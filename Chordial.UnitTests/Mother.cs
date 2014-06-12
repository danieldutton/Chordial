using System.Collections.Generic;

namespace Chordial.UnitTests
{
    public static class Mother
    {
        public static List<string> GetOpenStringNotes()
        {
            var noteList = new List<string>
            {
                "ELow", "A", "D", "G", "B", "EHigh",
            };

            return noteList;
        }

        public static List<string> ChromaticScale_A()
        {
            var scale = new List<string>
            {
                "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp",
            };

            return scale;
        }

        public static List<string> ChromaticScale_ASharp()
        {
            var scale = new List<string>
            {
                "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp", "A",
            };

            return scale;
        }

        public static List<string> ChromaticScale_B()
        {
            var scale = new List<string>
            {
                "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp","A", "ASharp", 
            };

            return scale;
        }

        public static List<string> ChromaticScale_C()
        {
            var scale = new List<string>
            {
                "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp","A", "ASharp", "B", 
            };

            return scale;
        }

        public static List<string> ChromaticScale_CSharp()
        {
            var scale = new List<string>
            {
                "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", "GSharp","A", "ASharp", "B", "C",
            };

            return scale;
        }

        public static List<string> ChromaticScale_D()
        {
            var scale = new List<string>
            {
                "D", "DSharp", "E", "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp",
            };

            return scale;
        }

        public static List<string> ChromaticScale_DSharp()
        {
            var scale = new List<string>
            {
                "DSharp", "E", "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", 
            };

            return scale;
        }

        public static List<string> ChromaticScale_E()
        {
            var scale = new List<string>
            {
                "E", "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", 
            };

            return scale;
        }

        public static List<string> ChromaticScale_F()
        {
            var scale = new List<string>
            {
                "F", "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", 
            };

            return scale;
        }

        public static List<string> ChromaticScale_FSharp()
        {
            var scale = new List<string>
            {
                "FSharp", "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", 
            };

            return scale;
        }

        public static List<string> ChromaticScale_G()
        {
            var scale = new List<string>
            {
                "G", "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", 
            };

            return scale;
        }

        public static List<string> ChromaticScale_GSharp()
        {
            var scale = new List<string>
            {
                "GSharp", "A", "ASharp", "B", "C", "CSharp", "D", "DSharp", "E", "F", "FSharp", "G", 
            };

            return scale;
        }
    }
}
