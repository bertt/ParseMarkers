using System.Xml.Serialization;

namespace ConsoleApp2
{
    [System.Serializable]
    public class Vector3
    {
        [XmlElement("x")]
        public float X { get; set; }
        [XmlElement("y")]
        public float Y { get; set; }
        [XmlElement("z")]
        public float Z { get; set; }
    }
}
