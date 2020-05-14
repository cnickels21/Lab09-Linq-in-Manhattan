using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Lab09LinqInManhattan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static object GetNeighborhoods()
        {
            string filePath = "data.json";
            string neighborhoods = File.ReadAllText(filePath);

            RootObject objectifiedNeighborhoods =
                JsonConvert.DeserializeObject<RootObject>(neighborhoods);

            return objectifiedNeighborhoods;
        }
    }
}
