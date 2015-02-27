using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace GenjiGloveCom
{
    public class Magnetometer
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
    public class Accelerometer
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
    public class Gyroscope
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
    }
    public class Joystick
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class Button
    {
        public bool state { get; set; }
    }
    public class EMG
    {
        public int value { get; set; }
    }
    public class GenjiGlove
    {

        public SerialPort Port;
        public int StreamSize;
        public int[] Stream;

        public Accelerometer Accelerometer;
        public Gyroscope Gyroscope;

        public Magnetometer Magnetometer_A;
        public Magnetometer Magnetometer_B;
        public Magnetometer Magnetometer_C;
        public Magnetometer Magnetometer_D;
        public Magnetometer Magnetometer_E;

        public Joystick Joystick;

        public Button Button_A;
        public Button Button_B;
        public Button Button_C;
        public Button Button_D;

        public EMG EMG;

        public void Initialize(string ComPort, int StreamSize=100, int Baud=115200)
        {
            this.Port = new SerialPort(ComPort, Baud);
            this.StreamSize = StreamSize;
        }

        public void ReadNext()
        {
            string line = Port.ReadLine();
            string[] values = line.Split(';');
        }
    }
}
