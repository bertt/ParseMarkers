
using System.Xml.Serialization;

namespace ConsoleApp2
{
    [System.Serializable]
    public class Quaternion
    {
        [XmlElement("x")]
        public float X { get; set; }
        [XmlElement("y")]
        public float Y { get; set; }
        [XmlElement("z")]
        public float Z { get; set; }
        [XmlElement("w")]
        public float W { get; set; }

        [XmlElement("eulerAngles")]
        public EulerAngles EulerAngles { get; set; }
    }
}
