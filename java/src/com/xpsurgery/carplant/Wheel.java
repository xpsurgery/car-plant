package com.xpsurgery.carplant;

import java.io.IOException;
import java.io.Writer;

class Wheel {

	private String name;
  private Writer listener;

	Wheel(String name, Writer listener) {
		this.name = name;
    this.listener = listener;
	}

	void turnLeft(int degrees) {
		report(name + " turning left " + degrees + " degrees\n");
	}

	void turnRight(int degrees) {
		report(name + " turning right " + degrees + " degrees\n");
	}

	void rotate(int kph) {
		report(name + " accelerating " + kph + " kph\n");
	}

	private void report(String event) {
		try {
      listener.write(event);
    } catch (IOException e) { }
	}

}

