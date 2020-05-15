using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab09LinqInManhattan
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public static RootObject GetNeighborhoods()
        {
            string filePath = "data.json";
            string neighborhoods = File.ReadAllText(filePath);

            dynamic objectifiedNeighborhoods =
                JsonConvert.DeserializeObject<RootObject>(neighborhoods);

            return objectifiedNeighborhoods;
        }
    }
}
