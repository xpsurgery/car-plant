package com.xpsurgery.carplant;

import java.io.Writer;

abstract class RearWheelDriveCar extends Car {

  RearWheelDriveCar(Writer listener) {
    super(listener);
  }

	public void accelerate(int kph) {
		_rearLeft.rotate(kph);
		_rearRight.rotate(kph);
	}
}

