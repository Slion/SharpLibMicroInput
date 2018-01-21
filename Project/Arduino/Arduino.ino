/*
Blink
Turns on an LED on for one second, then off for one second, repeatedly.

This example code is in the public domain.
*/

//#define SLOG

enum TDeviceType
{
	EDeviceTypeKeyboard=0,
	EDeviceTypeMouse = 1,
	EDeviceTypeJoystick = 2
};

enum TDeviceFunction
{
	EDeviceFunctionPrint = 0,
	EDeviceFunctionAction = 1,
	EDeviceFunctionPress = 2,
	EDeviceFunctionRelease = 3
};


struct PacketHeader
{
	TDeviceType iDeviceType: 8;
	TDeviceFunction iDeviceFunction : 8;
	uint8_t iDataSize: 8;
};

// Buffer to hold RawHID data.
// If host tries to send more data than this,
// it will respond with an error.
// If the data is not read until the host sends the next data
// it will also respond with an error and the data will be lost.
uint8_t rawhidData[64];

// Pin 13 has an LED connected on most Arduino boards.
// Pin 11 has the LED on Teensy 2.0
// Pin 6  has the LED on Teensy++ 2.0
// Pin 13 has the LED on Teensy 3.0
// give it a name:
int led = 13;

void Blink()
{
	for (int i = 0; i < 3; i++)
	{
		digitalWrite(led, HIGH);    // turn the LED off by making the voltage LOW
		delay(150);
		digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW
		delay(150);
	}
}

//
void LogBuffer(uint8_t* aPtr, int aSize)
{
	for (int i = 0; i < aSize; i++)
	{
		Serial.print(aPtr[i]);
		Serial.print(":");
	}

	Serial.println("");
}



// the setup routine runs once when you press reset:
void setup() {
	// initialize the digital pin as an output.
	pinMode(led, OUTPUT);
	
	Blink();

#ifdef SLOG
	Serial.print("Packet header size:");
	Serial.println(sizeof(PacketHeader));
#endif
}


// the loop routine runs over and over again forever:
void loop()
{

	/*
	digitalWrite(led, HIGH);   // turn the LED on (HIGH is the voltage level)
	delay(1000);               // wait for a second
	digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW
	delay(1000);               // wait for a second
	digitalWrite(led, HIGH);    // turn the LED off by making the voltage LOW
	delay(250);
	digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW
	delay(250);
	digitalWrite(led, HIGH);    // turn the LED off by making the voltage LOW
	delay(250);
	digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW
	delay(1000);
	*/
	//Keyboard.print("Hello World"); 

	int n;
	n = RawHID.recv(rawhidData, 0); // 0 timeout = do not wait
    
    // Valid packet must be larger than header
	if (n > sizeof(PacketHeader)) 
	{
		// First is our packet header
		PacketHeader& header = *((PacketHeader*)rawhidData);

#ifdef SLOG
		Serial.print("Packet size:");
		Serial.println(n);

		Serial.print("Device type:");
		Serial.println(header.iDeviceType);

		Serial.print("Data size:");
		Serial.println(header.iDataSize);

		// Log our buffer
		LogBuffer(rawhidData, sizeof(PacketHeader) + header.iDataSize);
#endif


		if (header.iDeviceType == EDeviceTypeKeyboard)
		{
			//Blink();

			if (header.iDeviceFunction == EDeviceFunctionPrint)
			{
				// Print function writes the given unicode string
				// Fetch our data
				uint16_t* ptr = (uint16_t*)(rawhidData + sizeof(PacketHeader));
				int entryCount = header.iDataSize / sizeof(uint16_t);						
				
				// Action all specified keys
				for (int i = 0; i < entryCount; i++)
				{

#ifdef SLOG
					Serial.print("Sending key:");
					Serial.println(ptr[i]);
#endif

					Keyboard.write_unicode(ptr[i]);

					//Keyboard.press(ptr[i]);
					//Keyboard.release(ptr[i]);
				}				
			}
			else if (header.iDeviceFunction == EDeviceFunctionAction)
			{
				// Fetch our data
				uint16_t* ptr = (uint16_t*)(rawhidData + sizeof(PacketHeader));
				int entryCount = header.iDataSize / sizeof(uint16_t);

				// Must have 2 entries: modifier and key itself
				if (entryCount == 2) 
				{
					// Apply modifier
					Keyboard.set_modifier(ptr[0]);
					// Action key
					Keyboard.press(ptr[1]);
					// Reset keys and modifiers
					Keyboard.releaseAll();
				}
			}
		}
		


#ifdef SLOG
		Serial.print("byteCount: ");
		Serial.println(byteCount);
#endif

		
		

		//Joystick.button(10,true);

		//Joystick.send_now();

		//Keyboard.print("Hi!");

		//delay(3000);


		/* 
		digitalWrite(led, HIGH);   // turn the LED on (HIGH is the voltage level)
		delay(1000);               // wait for a second
		digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW

		Keyboard.press(KEY_DOWN);
		Keyboard.release(KEY_DOWN);
		*/

		//Joystick.button(10,false);
		//Joystick.send_now();

	}


}
