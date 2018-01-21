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
        public void KeyboardAction(ushort aKey, ushort aModifier=0)
        {
            if (iDevice.IsOpen)
            {

                byte[] garbage = new byte[]
                {
                    // Report ID
                    0x00,
                    // Device Type: Keyboard
                    0x00,
                    // Device Function: Action
                    0x01,
                    // Data size
                    0x04,
                    // Data, big endian
                    // Unicode
                    (byte)aModifier,
                    (byte)(aModifier>>8),
                    (byte)aKey,
                    (byte)(aKey>>8)
                };

                iDevice.Write(garbage);                
            }
        }

        // NOTE: Make sure KPayloadSize is an even number
        // That makes sure our unicode characters do not get split between packets
        const int KHeaderSize = 4;
        const int KMaxPacketSize = 64;
        const int KPayloadSize = KMaxPacketSize - KHeaderSize;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="aText"></param>
        public void Print(string aText)
        {
            if (!iDevice.IsOpen)
            {
                return;
            }
            
            // Get our text as byte
            byte[] text = Encoding.Unicode.GetBytes(aText);
            
            int written = 0;

            while (written!=text.Length)
            {
                int packetSize=Math.Min(text.Length + KHeaderSize, KMaxPacketSize);
                int writeSize = Math.Min(text.Length-written, KMaxPacketSize-KHeaderSize);
                byte[] data = new byte[packetSize];
                data[0] = 0x00; // Report ID
                data[1] = 0x00; // Device Type: Keyboard
                data[2] = 0x00; // Function Type: Print
                data[3] = (byte)writeSize; // Data size
                Array.Copy(text, written, data, KHeaderSize, writeSize); // Copy our text
                                                                     //
                iDevice.Write(data);
                written += writeSize;
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
