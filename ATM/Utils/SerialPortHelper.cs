﻿using System.Collections.Generic;
using System.Globalization;
using System.IO.Ports;
using System.Linq;

namespace ATM
{
    public static class SerialPortHelper
    {
        public static string[] GetSerialPorts()
        {
            return SerialPort.GetPortNames().OrderBy(c => c).ToArray();
        }
    }
}
