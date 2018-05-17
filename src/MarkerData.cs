using ConsoleApp2;
using System.Xml.Serialization;

[System.Serializable]
public class MarkerData
{
    [XmlElement("type")]
    public int Type;
    [XmlElement("position")]
    public Vector3 Position;
    [XmlElement("orientation")]
    public Quaternion Orientation;
}