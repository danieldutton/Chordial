using NUnit.Framework;

namespace Chordial.UnitTests
{
    [TestFixture]
    public class Foo
    {
        [Test]
        public void FooBar()
        {
            //first we need to get a grid but how do we determine the grid size.
            //maybe builder patter
        }
    }

    //options

    /**
     * 1.  Builder Pattern
     * 2.  template method
     * 3.  Factory
     * 4.  do we need patterns at all. essentially generating a grid is pretty simle with just a few dimensions needed for customisation
     */

    public abstract class Builder
    {
            
    }

    public class ElectricSixStringBuilder
    {
        
    }

    public class ElectricTwelveStringBuilder
    {
        
    }

    public class Director
    {
        
    }

    //just for expereminting
    public class GridBuilder
    {
        public void BuildGrid()
        {
            
        }
    }

    //we need to feed something into the grid, a pattern as such
}
