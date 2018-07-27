using System.Collections.Generic;
using NUnit.Framework;
using TeamRandomizer.Models;

namespace TeamRandomizer.Tests
{
    [TestFixture]
    public class RandomizeTeamsTests
    {
        [Test]
        public void RandomizeTeams_ShouldRandomizeListOfNames()
        {
            // Arrange
            var sut = new RandomizeTeams();

            List<string> names = new List<string> { "Name1", "Name2", "Name3", "Name4", "Name5", "Name6" };

            // Act
            var result = sut.Randomize(names);

            // Assert
            //Assert.AreNotEqual(names, result);
        }
    }
}
