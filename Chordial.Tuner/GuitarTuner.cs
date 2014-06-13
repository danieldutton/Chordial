using Chordial.Luthier.Model;
using Chordial.Scales.Interfaces;
using Chordial.Scales.Model;
using Chordial.Tuner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chordial.Tuner
{
    public class GuitarTuner 
    {
        private readonly IScaleGenerator _scaleGenerator;
        
        private readonly ITuningMap _map;

        public GuitarTuner(IScaleGenerator scaleGenerator, ITuningMap map)
        {
            _scaleGenerator = scaleGenerator;
            _map = map;
        }

        public FretSpace[,] TuneString(GuitarString stringToTune, FretSpace[,] fretboard)
        {
            if (fretboard == null) throw new ArgumentNullException("fretboard");
            
            //can we extension method this in utilities
            if(!Enum.IsDefined(typeof(GuitarString), stringToTune))
                stringToTune = GuitarString.A;

            Dictionary<GuitarString, Scale> stringToScaleMap = _map.GetMap();

            Scale scale = stringToScaleMap[stringToTune];
            
            List<string> notes = _scaleGenerator.GetScale(scale).ToList();
            
            int currentFretSpace = 0;

            for (int i = 0; i < fretboard.GetLength(0); i++)
            {
                currentFretSpace++;

                if (currentFretSpace == fretboard.GetLength(0))
                    break;

                if (i == notes.Count())
                    i = 0;
               
                //tune the string
                fretboard[(int) stringToTune, i].Note = notes[i]; 
            }
            return fretboard;
        }      
    }
}
