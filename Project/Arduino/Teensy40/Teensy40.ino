/*
Blink
Turns on an LED on for one second, then off for one second, repeatedly.

This example code is in the public domain.
*/

#include "MicroInput.h"

// the setup routine runs once when you press reset:
void setup() 
{
	MicroInput::Setup();
}


// the loop routine runs over and over again forever:
void loop()
{
	MicroInput::Loop();
}
