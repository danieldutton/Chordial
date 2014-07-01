using Chordial.Utility.Interfaces;

namespace Chordial.Luthier.Model
{
    public struct FretSpace : IPlottable, IResourceConsumer
    {
        public string Note { get; set; }

        public int XPos { get; set; }

        public int YPos { get; set; }

        public bool IsPressed { get; set; }
        
        public string ResourceName { get; set; }



        public override string ToString()
        {
            return string.Format("[{0}] Note:{1} XPos:{2} YPos{3} IsPressed:{4} ResourceName:{5}",
                GetType().Name, Note, XPos, YPos, IsPressed, ResourceName);
        }
    }
}
