using System;

namespace DesginPattern
{
    public class Material
    {
        public Guid MaterialID { get; set; }
        public decimal Budget { get; set; }
        public string DrawingNumber { get; set; }
        public string Name { get; set; }
        public string PartNumber { get; set; }
    }
}