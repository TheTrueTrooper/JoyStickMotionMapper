using SharpDX.DirectInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyStickMotionMapper.MotionHardwareInterface
{
    interface IMotionHardwareInterface : IDisposable
    {
        void SetCylinderHeight(byte num, byte height);

        void ZeroAllCylinders();

        void ReleaseHardware();

        void GrabHardware();
    }
}
