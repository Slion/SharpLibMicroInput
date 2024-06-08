# SharpLibMicroInput
Input emulation via microcontroller as a .NET library


# Board support

I've been using [Visual Micro](https://www.visualmicro.com) to build firmwares from Visual Studio 2022.
Though I guess you could in theory build them from the Arduino IDE too.

# Teensy 4.0 setup

Here are instructions you need to follow to be able to build and flash your Teensy 4.0 with Micro Input firmware.
Once your are done 

## Add Micro Input USB type to options menu


Edit the `boards.txt` typically located in `%LOCALAPPDATA%\Arduino15\packages\teensy\hardware\avr\1.59.0` and locate the following lines:

```
teensy40.menu.usb.rawhid=Raw HID
teensy40.menu.usb.rawhid.build.usbtype=USB_RAWHID
teensy40.menu.usb.rawhid.upload_port.usbtype=USB_RAWHID
teensy40.menu.usb.rawhid.fake_serial=teensy_gateway
```

Insert those lines just after them

```
teensy40.menu.usb.microinput=Micro Input
teensy40.menu.usb.microinput.build.usbtype=USB_MICRO_INPUT
teensy40.menu.usb.microinput.upload_port.usbtype=USB_MICRO_INPUT
teensy40.menu.usb.microinput.fake_serial=teensy_gateway
```

## Add USB descriptor type

Edit `usb_desc.h` typically located in `%LOCALAPPDATA%\Arduino15\packages\teensy\hardware\avr\1.59.0\cores\teensy4` and insert the following lines after the `USB_RAWHID` configuration:

```
  #elif defined(USB_MICRO_INPUT)
    #define VENDOR_ID		0x2808
    #define PRODUCT_ID	0x0000
    #define BCD_DEVICE		0x0001
    #define RAWHID_USAGE_PAGE	0xFFAB  // recommended: 0xFF00 to 0xFFFF
    #define RAWHID_USAGE		0x0200  // recommended: 0x0100 to 0xFFFF
    #define MANUFACTURER_NAME	{'S','l','i','o','n','s'}
    #define MANUFACTURER_NAME_LEN	6
    #define PRODUCT_NAME		{'M','i','c','r','o','I','n','p','u','t'}
    #define PRODUCT_NAME_LEN	10
    #define EP0_SIZE		64
    #define NUM_ENDPOINTS         6
    #define NUM_INTERFACE         4	
    #define NUM_USB_BUFFERS	      24
    // RawHID	
    #define RAWHID_INTERFACE      0	
    #define RAWHID_TX_ENDPOINT    2
    #define RAWHID_TX_SIZE        64
    #define RAWHID_TX_INTERVAL    1	
    #define RAWHID_RX_ENDPOINT    3
    #define RAWHID_RX_SIZE        64
    #define RAWHID_RX_INTERVAL    1	 
    // Serial Emulation
    #define SEREMU_INTERFACE      1
    #define SEREMU_TX_ENDPOINT    4
    #define SEREMU_TX_SIZE        64
    #define SEREMU_TX_INTERVAL    1	 
    #define SEREMU_RX_ENDPOINT    4
    #define SEREMU_RX_SIZE        32
    #define SEREMU_RX_INTERVAL    2	 
    
    #define ENDPOINT2_CONFIG	ENDPOINT_RECEIVE_UNUSED + ENDPOINT_TRANSMIT_INTERRUPT
    #define ENDPOINT3_CONFIG	ENDPOINT_RECEIVE_INTERRUPT + ENDPOINT_TRANSMIT_UNUSED
    #define ENDPOINT4_CONFIG	ENDPOINT_RECEIVE_INTERRUPT + ENDPOINT_TRANSMIT_INTERRUPT
    
  // Keyboard
    #define KEYBOARD_INTERFACE    2	
    #define KEYBOARD_ENDPOINT     5
    #define KEYBOARD_SIZE         8
    #define KEYBOARD_INTERVAL     1
    // Keyboard Media Keys
    #define KEYMEDIA_INTERFACE    3	
    #define KEYMEDIA_ENDPOINT     6
    #define KEYMEDIA_SIZE         8
    #define KEYMEDIA_INTERVAL     4
    // Mouse
    /*
    #define MOUSE_INTERFACE       4	
    #define MOUSE_ENDPOINT        7
    #define MOUSE_SIZE            8
    #define MOUSE_INTERVAL        1
    */
    //SL: Joystick currently not working together with RawHID on Teensy 4.0
    /*
    #define JOYSTICK_INTERFACE    5	// Joystick
    #define JOYSTICK_ENDPOINT     7
    #define JOYSTICK_SIZE         12	//  12 = normal, 64 = extreme joystick
    #define JOYSTICK_INTERVAL     2
    */
    
    #define ENDPOINT5_CONFIG	ENDPOINT_RECEIVE_UNUSED + ENDPOINT_TRANSMIT_INTERRUPT
    #define ENDPOINT6_CONFIG	ENDPOINT_RECEIVE_UNUSED + ENDPOINT_TRANSMIT_INTERRUPT
  // #define ENDPOINT7_CONFIG	ENDPOINT_RECEIVE_UNUSED + ENDPOINT_TRANSMIT_INTERRUPT
    //#define ENDPOINT8_CONFIG	ENDPOINT_RECEIVE_UNUSED + ENDPOINT_TRANSMIT_INTERRUPT
```

