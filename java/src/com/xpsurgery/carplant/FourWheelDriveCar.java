package com.xpsurgery.carplant;

import java.io.Writer;

abstract class FourWheelDriveCar extends Car {

  FourWheelDriveCar(Writer listener) {
    super(listener);
  }

	public void accelerate(int kph) {
		_frontLeft.rotate(kph);
		_frontRight.rotate(kph);
		_rearLeft.rotate(kph);
		_rearRight.rotate(kph);
	}
}

