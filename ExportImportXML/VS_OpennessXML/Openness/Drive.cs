using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.MC.Drives;


namespace OpennessLibrary
{
    public partial class Openness
    {
        public void ChangePM(string ordernumber)
        {

        }

        public void ChangeIP(string ipaddress)
        {

        }

        public DriveObject GetDriveObject(Device device)
        {
            DriveObject driveObject = null;
            if (device != null)
            {
                DeviceItem deviceItem = GetHM(device);
                driveObject = deviceItem.GetService<DriveObjectContainer>().DriveObjects[0];
            }
            return driveObject;
        }
    }
}
