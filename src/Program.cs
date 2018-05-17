using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var path = @"test.xml";
            var serializer = new XmlSerializer(typeof(List<MarkerData>));
            var stream = new FileStream(path, FileMode.Open);
            var markers = (List<MarkerData>)serializer.Deserialize(stream);
            foreach (var marker in markers)
            {
                Console.WriteLine($"position: {marker.Position.X},{marker.Position.Y}, {marker.Position.Z}");
            }
            Console.WriteLine($"Number of markers: {markers.Count}");
            Console.ReadKey();
        }
    }
}
