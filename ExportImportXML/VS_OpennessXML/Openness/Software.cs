using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siemens.Engineering;
using Siemens.Engineering.HW;
using Siemens.Engineering.HW.Features;
using Siemens.Engineering.SW;

namespace OpennessLibrary
{
    public partial class Openness
    {
        public PlcSoftware Plc_GetSoftware(Device device)
        {
            if (Project == null)
            {
                return null;
            }

            PlcSoftware plcSoftware = null;

            try
            {
                DeviceItem cpuItem = Device_GetCPU(device);
                if (cpuItem != null)
                {
                    SoftwareContainer softwareContainer = cpuItem.GetService<SoftwareContainer>();
                    plcSoftware = softwareContainer.Software as PlcSoftware;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception");
            }

            return plcSoftware;
        } 
    }
}
