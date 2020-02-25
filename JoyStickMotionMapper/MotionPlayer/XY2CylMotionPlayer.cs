using JoyStickMotionMapper.TimingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyStickMotionMapper.MotionPlayer
{
    class XY2CylMotionPlayer : BaseMotionPlayer
    {
        internal XY2CylMotionPlayer(TaPa_XYCyl Owner, string MotionDataPath, string GamePath, string StartOptionsRunArgs, string RuntimeProccess, string StartOptionsInput, AvalibleProtocols MotionDeviceProtocol, string ConnectionString) : base (Owner, MotionDataPath, GamePath, StartOptionsRunArgs, RuntimeProccess, StartOptionsInput, MotionDeviceProtocol, ConnectionString) {}
        protected override void AnimateFame(MomentaryPositionAndTimingFrameDataModel Data)
        {
            MotionHardwareInterface.SetCylinderHeight(1, Data.C1);
            MotionHardwareInterface.SetCylinderHeight(2, Data.C2);
        }
    }
}
