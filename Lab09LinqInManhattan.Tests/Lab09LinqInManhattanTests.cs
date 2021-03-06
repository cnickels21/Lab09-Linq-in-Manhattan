using System.Collections.Generic;
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

        [Fact]
        public void Filter_out_Duplicates()
        {
            // Arrange
            RootObject result = Program.GetNeighborhoods();
            int numberOfHoods =
                Enumerable.Count<object>(result.features);


            // Act
            var filterNoNames =
                (from feature
                in result.features
                where feature.properties.neighborhood != ""
                select feature.properties.neighborhood).Distinct();

            // Assert
            Assert.Equal(39, filterNoNames.Count());

        }
 

        [Fact]
        public void Filter_out_Duplicates_With_Where_Method()
        {
            // Arrange
            RootObject result = Program.GetNeighborhoods();
            int numberOfHoods =
                Enumerable.Count<object>(result.features);


            // Act
            IEnumerable<object> theseHoods = result.features
                .Where(numberOfHoods =>
                !numberOfHoods.properties.neighborhood
                .Equals(""))
                .Select(feature => feature.properties.neighborhood)
                .Distinct();

           

            // Assert
            Assert.Equal(39, theseHoods.Count());

        }
    }

}
