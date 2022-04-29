using FluentAssertions;
using SwissTransport.Core;
using SwissTransport.Models;
using Xunit;
namespace SwissTransport
{
    public class UITestBase
    {
        private readonly ITransport testee;

        public UITestBase()
        {
            this.testee = new Transport();
        }

        [Fact]
        public void Locations()
        {
            Stations stations = this.testee.GetStations("Sursee, Luzern, ");

            stations.StationList.Should().NotBeNull();
        }

    }
}