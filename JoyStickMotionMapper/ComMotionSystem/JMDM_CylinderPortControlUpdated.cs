using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using JoyStickMotionMapper.MotionHardwareInterface;

namespace JoyStickMotionMapper.ComMotionSystem
{
    public class JMDM_CylinderPortControlUpdated : IDisposable, IMotionHardwareInterface
    {
        internal SerialPort sp_send { set; get; }

        internal string send_port { private set; get; }

        internal int CylinderCount { private set; get; }

        internal bool IsOpen
        {
            get => sp_send.IsOpen;
        }

        internal JMDM_CylinderPortControlUpdated(string sendport, int CylinderCount)
        {
            send_port = sendport;
            sp_send = new SerialPort(send_port, 9600, Parity.None, 8, StopBits.One);
            sp_send.ReadTimeout = 400;
            this.CylinderCount = CylinderCount;
        }

        internal void Open_Port()
        {
            if (!sp_send.IsOpen)
            {
                sp_send.Open();
            }
        }

        internal static IMotionHardwareInterface ConnectionFactory(string ConnectionString)
        {
            JMDM_CylinderPortControlUpdated Return = new JMDM_CylinderPortControlUpdated(ConnectionString, 6);
            return Return;
        }


        //num  1-6   height  10-250    3个缸的行程控制
        //num 1-6 height 10-250 3 cylinder stroke control
        public void SetCylinderHeight(byte num, byte height)
        {
            string str = string.Format("OC(0{0},{1:D3})", num, height);
            if (sp_send.IsOpen)
            {
                sp_send.Write(str);
            }
            else
                throw new Exception("Port is not open");
        }

        public void ZeroAllCylinders()
        {
            for (int i = 0; i < CylinderCount; i++)
            {
                if (sp_send.IsOpen)
                {

                    sp_send.Write(string.Format("OC({0},000)", i));
                }
                else
                    throw new Exception("Port is not open");
            }
        }

        internal void Close_Port()
        {
            if (sp_send.IsOpen)
            {
                sp_send.Close();
            }
        }

        public void Dispose()
        {
            Close_Port();
            sp_send.Dispose();
        }

        public void ReleaseHardware()
        {
            Close_Port();
        }

        public void GrabHardware()
        {
            Open_Port();
        }

        ~JMDM_CylinderPortControlUpdated()
        {
            Close_Port();
            sp_send.Dispose();
        }
    }
}

