namespace Chordial.FretboardBuilder
{
    public class Note
    {
        public NoteName NoteName { get; set; }
        public int FretPositionX { get; set; }
        public int FretPositionY { get; set; }
        public string ResourceName { get; set; }
        public int OctaveLevel { get; set; }
    }
}
