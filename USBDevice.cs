using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;


public class USBDevice
{
    public int busNumber { get; set; }
    public int deviceAddress { get; set; }
    public USBDeviceDescriptor deviceDescriptor { get; set; }
    public List<int> portNumbers { get; set; } = new List<int>();


    public override string ToString()
        => JObject.FromObject(this).ToString();
}
