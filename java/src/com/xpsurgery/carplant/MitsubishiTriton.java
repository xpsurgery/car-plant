package com.xpsurgery.carplant;

import java.io.Writer;

class MitsubishiTriton extends FourWheelDriveCar {

  MitsubishiTriton(Writer listener) {
    super(listener);
  }

	public String name() {
		return "Mitsubishi Triton";
	}
}

