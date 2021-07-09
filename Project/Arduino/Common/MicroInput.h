/*
Blink
Turns on an LED on for one second, then off for one second, repeatedly.

This example code is in the public domain.
*/

#include <Arduino.h>

/**
 * Utility class defining Arduino entry points.
 * Allows us to use the same code from multiple projects to support multiple boards.
 */
class MicroInput
{
public:
	static void Setup();
	static void Loop();
};

