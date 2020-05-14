using System.Linq;
using Xunit;

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

        [Fact]
        public void First_zip_code_accessed()
        {
            // Arrange
            RootObject result = Program.GetNeighborhoods();

            // Assert
            Assert.Equal("10001", result.features.First().properties.zip);

        }

        [Fact]
        public void Counting_all_the_neighborhoods()
        {
            // Arrange
            RootObject result = Program.GetNeighborhoods();

            // Act
            int numberOfHoods = 
                Enumerable.Count<object>(result.features);

            // Assert: 147 neighborhoods selected
            Assert.Equal(147, numberOfHoods);
        }

        [Fact]
        public void Filter_all_features_without_name()
        {
            // Arrange
            RootObject result = Program.GetNeighborhoods();
            int numberOfHoods = 
                Enumerable.Count<object>(result.features);


            // Act
            var filterNoNames =
                from feature
                in result.features
                where feature.properties.neighborhood != ""
                select feature.properties.neighborhood;

            // Assert
            Assert.Equal(143, filterNoNames.Count());

        }
    }
}
