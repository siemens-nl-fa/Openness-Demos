using Siemens.Engineering.HW;
using Siemens.Engineering.Library.MasterCopies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpennessLibrary
{
     public partial class Openness
     {
          /// <summary>
          /// Returns a list of all the devices in the project.
          /// </summary>
          /// <returns></returns>
          public List<Device> Project_GetDevices()
          {
               if (Project == null)
               {
                    return null;
               }

               List<Device> devices = new List<Device>();

               try
               {
                    foreach (Device device in Project.Devices)
                    {
                         devices.Add(device);
                    }
                    foreach (Device device in Project.UngroupedDevicesGroup.Devices)
                    {
                         devices.Add(device);
                    }
                    foreach (DeviceUserGroup deviceGroup in Project.DeviceGroups)
                    {
                         List<Device> devicesInGroup = Project_GetDevicesFromGroup(deviceGroup);
                         devices.AddRange(devicesInGroup);
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return devices;
          }

          /// <summary>
          /// Return a list of the devices in a device group folder.
          /// </summary>
          /// <param name="deviceGroup"></param>
          /// <returns></returns>
          private List<Device> Project_GetDevicesFromGroup(DeviceUserGroup deviceGroup)
          {
               if (Project == null)
               {
                    return null;
               }

               List<Device> devices = new List<Device>();

               try
               {
                    foreach (Device device in deviceGroup.Devices)
                    {
                         devices.Add(device);
                    }
                    foreach (DeviceUserGroup deviceGroupInGroup in deviceGroup.Groups)
                    {
                         devices.AddRange(Project_GetDevicesFromGroup(deviceGroupInGroup));
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return devices;
          }

          /// <summary>
          /// Creates a device in the project from an ordernumber.
          /// </summary>
          /// <param name="orderNumber"></param>
          /// <param name="name"></param>
          /// <param name="deviceName"></param>
          /// <param name="deviceComposition"></param>
          /// <returns></returns>
          public Device Device_Add(string orderNumber, string name, string deviceName, DeviceComposition deviceComposition)
          {
               if (Project == null)
               {
                    return null;
               }

               Device device = null;

               try
               {
                    if (Project_GetDevices().Find(d => d.Name == name) != null)
                    {
                         return null;
                    }

                    device = deviceComposition.CreateWithItem($"OrderNumber:{orderNumber}", name, deviceName);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return device;
          }

          /// <summary>
          /// Creates a device from a mastercopy in the projectlibrary.
          /// </summary>
          /// <param name="masterCopy"></param>
          /// <param name="deviceComposition"></param>
          /// <returns></returns>
          public Device Device_Add(MasterCopy masterCopy, DeviceComposition deviceComposition)
          {
               if (Project == null)
               {
                    return null;
               }

               Device device = null;

               try
               {
                    device = deviceComposition.CreateFrom(masterCopy);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return device;
          }

          /// <summary>
          /// Search for a device by name and return the device object.
          /// </summary>
          /// <param name="deviceName"></param>
          /// <returns></returns>
          public Device Device_GetDevice(string deviceName)
          {
               if (Project == null)
               {
                    return null;
               }

               Device device = null;

               try
               {
                    List<Device> devices = Project_GetDevices();
                    device = devices.Find(d => d.Name == deviceName);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return device;
          }

          /// <summary>
          /// Get the hardware deviceitem of a device.
          /// </summary>
          /// <param name="device"></param>
          /// <returns></returns>
          public DeviceItem Device_GetHM(Device device)
          {
               if (Project == null)
               {
                    return null;
               }

               DeviceItem deviceItem = null;

               try
               {
                    if (device != null)
                    {
                         foreach (DeviceItem item in device.DeviceItems)
                         {
                              if (item.Classification == DeviceItemClassifications.HM)
                              {
                                   deviceItem = item;
                                   break;
                              }
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return deviceItem;
          }

          /// <summary>
          /// Get the CPU deviceitem of a device.
          /// </summary>
          /// <param name="device"></param>
          /// <returns></returns>
          public DeviceItem Device_GetCPU(Device device)
          {
               if (Project == null)
               {
                    return null;
               }

               DeviceItem deviceItem = null;

               try
               {
                    if (device != null)
                    {
                         foreach (DeviceItem item in device.DeviceItems)
                         {
                              if (item.Classification == DeviceItemClassifications.CPU)
                              {
                                   deviceItem = item;
                                   break;
                              }
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return deviceItem;
          }

          /// <summary>
          /// Returns a list of all the profinet interfaces of a device.
          /// </summary>
          /// <param name="device"></param>
          /// <returns></returns>
          public List<DeviceItem> Device_GetProfinetInterfaces(Device device)
          {
               if (Project == null)
               {
                    return null;
               }

               List<DeviceItem> profinetInterfaces = new List<DeviceItem>();

               try
               {
                    if (device != null)
                    {
                         DeviceItem module = Device_GetCPU(device);
                         if (module != null)
                         {
                              foreach (DeviceItem item in module.DeviceItems)
                              {
                                   if (item.Name.Contains("PROFINET"))
                                   {
                                        profinetInterfaces.Add(item);
                                   }
                              }
                         }

                         module = Device_GetHM(device);
                         if (module != null)
                         {
                              foreach (DeviceItem item in module.DeviceItems)
                              {
                                   if (item.Name.Contains("PROFINET"))
                                   {
                                        profinetInterfaces.Add(item);
                                   }
                              }
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return profinetInterfaces;
          }

          /// <summary>
          /// Returns a specific profinet interface that is searched by name.
          /// </summary>
          /// <param name="device"></param>
          /// <param name="profinetInterfaceName"></param>
          /// <returns></returns>
          public DeviceItem Device_GetProfinetInterface(Device device, string profinetInterfaceName)
          {
               if (Project == null)
               {
                    return null;
               }

               DeviceItem deviceItem = null;

               try
               {
                    if (device != null)
                    {
                         DeviceItem module = Device_GetCPU(device);
                         if (module != null)
                         {
                              foreach (DeviceItem item in module.DeviceItems)
                              {
                                   if (item.Name == profinetInterfaceName)
                                   {
                                        deviceItem = item;
                                   }
                              }
                         }

                         module = Device_GetHM(device);
                         if (module != null)
                         {
                              foreach (DeviceItem item in module.DeviceItems)
                              {
                                   if (item.Name == profinetInterfaceName)
                                   {
                                        deviceItem = item;
                                   }
                              }
                         }
                    }
               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString(), "Exception");
               }

               return deviceItem;
          }
     }
}
