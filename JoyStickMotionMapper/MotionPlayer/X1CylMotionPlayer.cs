using JoyStickMotionMapper.ConfigHelper;
using JoyStickMotionMapper.TimingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyStickMotionMapper.MotionPlayer
{
    class X1CylMotionPlayer : BaseMotionPlayer
    {
        internal X1CylMotionPlayer(TaPa_XYCyl Owner, string MotionDataPath, string GamePath, string StartOptionsRunArgs, string RuntimeProccess, string StartOptionsInput, AvalibleProtocols MotionDeviceProtocol, string ConnectionString) : base (Owner, MotionDataPath, GamePath, StartOptionsRunArgs, RuntimeProccess, StartOptionsInput, MotionDeviceProtocol, ConnectionString) { }

        protected override void AnimateFame(MomentaryPositionAndTimingFrameDataModel Data)
        {
            MotionHardwareInterface.SetCylinderHeight(0, Data.C1);
        }
    }
}
