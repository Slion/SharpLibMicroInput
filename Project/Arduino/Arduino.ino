/*
Blink
Turns on an LED on for one second, then off for one second, repeatedly.

This example code is in the public domain.
*/

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

// the setup routine runs once when you press reset:
void setup() {
	// initialize the digital pin as an output.
	pinMode(led, OUTPUT);

	for (int i = 0; i < 3; i++)
	{
		digitalWrite(led, HIGH);    // turn the LED off by making the voltage LOW
		delay(150);
		digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW
		delay(150);
	}

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
	if (n > 0)
	{
		//isIdle = false;
		int byteCount = rawhidData[0];
#ifdef SLOG
		Serial.print("byteCount: ");
		Serial.println(byteCount);
#endif
		//Joystick.button(10,true);

		//Joystick.send_now();

		//Keyboard.print("Hi!");

		delay(3000);

		Keyboard.press(KEY_UP);
		Keyboard.release(KEY_UP);

		digitalWrite(led, HIGH);   // turn the LED on (HIGH is the voltage level)
		delay(1000);               // wait for a second
		digitalWrite(led, LOW);    // turn the LED off by making the voltage LOW

		Keyboard.press(KEY_DOWN);
		Keyboard.release(KEY_DOWN);


		//Joystick.button(10,false);
		//Joystick.send_now();

	}


}
