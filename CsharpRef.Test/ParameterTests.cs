using System;
using Xunit;

namespace CsharpRef.Test
{
    public class ParameterTests
    {

        [Fact]
        public void PassByValueTest()
        {

        }

        [Fact]
        public void PassByReferenceTest()
        {
            Artist artist = new Artist(1, "Tom Hanks", new DateTime(1956, 7, 9));

            ArtistUpdateManager.UpdateArtistName(artist, "Brad Pitt");
            
            artist.GetName().Should().Be()
            
        }
    }
}
