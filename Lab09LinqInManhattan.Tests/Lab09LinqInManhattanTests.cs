using Xunit;
using Lab09LinqInManhattan;
using System;

namespace Lab09LinqInManhattan.Tests
{
    public class Lab09LinqInManhattanTests
    {
        [Fact]
        public void Json_data_retrieved_from_file()
        {
            // Act
            var result = Program.GetNeighborhoods();

            // Assert
            Assert.NotNull(result);

        }
    }
}
