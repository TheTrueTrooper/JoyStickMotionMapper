using JoyStickMotionMapper.TimingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyStickMotionMapper.MotionPlayer
{
    class ParachuteMotionPlayer : BaseMotionPlayer
    {
        internal ParachuteMotionPlayer(TaPa_XYCyl Owner, string MotionDataPath, string GamePath, string StartOptionsRunArgs, string RuntimeProcess, string StartOptionsInput, AvalibleProtocols MotionDeviceProtocol, string ConnectonString) : base (Owner, MotionDataPath, GamePath, StartOptionsRunArgs, RuntimeProcess, StartOptionsInput, MotionDeviceProtocol, ConnectonString){}

        protected override void AnimateFame(MomentaryPositionAndTimingFrameDataModel Data)
        {
            MotionHardwareInterface.SetCylinderHeight(1, Data.C1);
            MotionHardwareInterface.SetCylinderHeight(2, Data.C2);
            MotionHardwareInterface.SetCylinderHeight(3, Data.C3);
        }
    }
}
