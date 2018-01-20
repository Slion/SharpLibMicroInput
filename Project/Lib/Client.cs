using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidLibrary;

namespace SharpLib.MicroInput
{
    public class Client
    {
        private HidDevice iDevice;

        /// <summary>
        /// 
        /// </summary>
        public void Open()
        {
            const int KVendorIdPjrc = 0x16C0;
            const int KProductIdTeensy32KeyboardMouseJoystick = 0x0482;
            const int KProductIdTeensy32RawHid = 0x0486;
            const int KProductIdTeensy32AllTheThings = 0x0476;
            const ushort RawUsagePage = 0xFFAB;
            iDevice = HidDevices.Enumerate(KVendorIdPjrc, KProductIdTeensy32AllTheThings, RawUsagePage).FirstOrDefault();
            iDevice.OpenDevice(DeviceMode.Overlapped, DeviceMode.Overlapped, ShareMode.ShareRead|ShareMode.ShareWrite);

        }

        /// <summary>
        /// 
        /// </summary>
        public void Test()
        {
            if (iDevice.IsOpen)
            {
                byte[] garbage = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                iDevice.Write(garbage);                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Close()
        {
            iDevice.CloseDevice();
            iDevice.Dispose(); // Needed?
            iDevice = null;
        }
    }
}
