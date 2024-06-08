using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidLibrary;

namespace SharpLib.MicroInput
{
    /// <summary>
    /// Controls a micro input device.
    /// Our micro input device is typically a Teeensy 3.2 board.
    /// </summary>
    public class Client
    {
        private HidDevice iDevice;

        public const int KVendorIdPjrc = 0x16C0;
        public const int KVendorIdSlions = 0x2808;
        public const int KProductIdMicroInput = 0x0000;
        public const int KProductIdTeensy32KeyboardMouseJoystick = 0x0482;
        public const int KProductIdTeensy32RawHid = 0x0486;
        public const int KProductIdTeensy32AllTheThings = 0x0476;
        public const ushort RawUsagePage = 0xFFAB;

        /// <summary>
        /// 
        /// </summary>
        public void Open(int aVendorId = KVendorIdSlions, int aProductId = KProductIdMicroInput, int aUsagePage = RawUsagePage)
        {
            //iDevice = HidDevices.Enumerate(KVendorIdPjrc, KProductIdTeensy32RawHid, RawUsagePage).FirstOrDefault();
            iDevice = HidDevices.Enumerate(aVendorId, aProductId, aUsagePage).FirstOrDefault();
            if (iDevice!=null)
            {
                iDevice.OpenDevice(DeviceMode.Overlapped, DeviceMode.Overlapped, ShareMode.ShareRead | ShareMode.ShareWrite);
            }            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsOpen
        {
            get
            {
                return iDevice != null && iDevice.IsOpen;
            }
        }

        /// <summary>
        /// Request a key action from our device.
        /// It should result in the corresponding key being pushed and released.
        /// No keyboard layout translation is applied as key codes simply define hardware keys.
        /// Therefore the end result of such an action very much depends of your actual keyboard layout and the application interpreting it.
        /// Use the Print function if want a result that's independent of the keyboard layout.
        /// 
        /// </summary>
        /// <param name="aKey">A key code constant from SharpLib.MicroInput.Keyboard.Key.</param>
        /// <param name="aModifier">A key modifier combination from SharpLib.MicroInput.Keyboard.Modifier</param>
        public void KeyboardAction(ushort aKey, ushort aModifier=0)
        {
            if (!iDevice.IsOpen)
            {
                return;
            }

            byte[] data = new byte[]
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

            iDevice.Write(data);                
            
        }


        /// <summary>
        /// Request a key press from our device.
        /// It should result in the corresponding key being pushed.
        /// No keyboard layout translation is applied as key codes simply define hardware keys.
        /// Therefore the end result of such an action very much depends of your actual keyboard layout and the application interpreting it.
        /// Use the Print function if want a result that's independent of the keyboard layout.
        /// 
        /// </summary>
        /// <param name="aKey">A key code constant from SharpLib.MicroInput.Keyboard.Key.</param>
        /// <param name="aModifier">A key modifier combination from SharpLib.MicroInput.Keyboard.Modifier</param>
        public void KeyboardPress(ushort aKey, ushort aModifier = 0)
        {
            if (!iDevice.IsOpen)
            {
                return;
            }

            byte[] data = new byte[]
            {
                // Report ID
                0x00,
                // Device Type: Keyboard
                0x00,
                // Device Function: Press
                0x02,
                // Data size
                0x04,
                // Data, big endian
                // Unicode
                (byte)aModifier,
                (byte)(aModifier>>8),
                (byte)aKey,
                (byte)(aKey>>8)
            };

            iDevice.Write(data);

        }


        /// <summary>
        /// Request a key release from our device.
        /// It should result in the corresponding key being released.
        /// No keyboard layout translation is applied as key codes simply define hardware keys.
        /// Therefore the end result of such an action very much depends of your actual keyboard layout and the application interpreting it.
        /// Use the Print function if want a result that's independent of the keyboard layout.
        /// 
        /// </summary>
        /// <param name="aKey">A key code constant from SharpLib.MicroInput.Keyboard.Key.</param>
        /// <param name="aModifier">A key modifier combination from SharpLib.MicroInput.Keyboard.Modifier</param>
        public void KeyboardRelease(ushort aKey, ushort aModifier = 0)
        {
            if (!iDevice.IsOpen)
            {
                return;
            }

            byte[] data = new byte[]
            {
                // Report ID
                0x00,
                // Device Type: Keyboard
                0x00,
                // Device Function: Release
                0x03,
                // Data size
                0x04,
                // Data, big endian
                // Unicode
                (byte)aModifier,
                (byte)(aModifier>>8),
                (byte)aKey,
                (byte)(aKey>>8)
            };

            iDevice.Write(data);

        }


        /// <summary>
        /// Release all keys on your keyboard.
        /// </summary>
        public void KeyboardReleaseAll()
        {
            if (iDevice == null || !iDevice.IsOpen)
            {
                return;
            }

            byte[] data = new byte[]
            {
                // Report ID
                0x00,
                // Device Type: Keyboard
                0x00,
                // Device Function: Release All
                0x04,
                // Data size
                0x00
            };

            iDevice.Write(data);

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
            // Make sure no keys remain pushed
            KeyboardReleaseAll(); //TODO: put that in dispose?
            //
            iDevice?.CloseDevice();
            iDevice?.Dispose(); // Needed?
            iDevice = null;
        }
    }
}
