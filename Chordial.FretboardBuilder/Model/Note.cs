namespace Chordial.FretboardBuilder.Model
{
    public struct Note
    {
        public string Scale { get; set; }
        
        public int FretPositionX { get; set; }
        
        public int FretPositionY { get; set; }
        
        public string ResourceName { get; set; }
        
        public int OctaveLevel { get; set; }
    }
}
