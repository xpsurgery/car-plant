package com.xpsurgery.carplant;

import java.io.Writer;

abstract class FrontWheelDriveCar extends Car {

  FrontWheelDriveCar(Writer listener) {
    super(listener);
  }

	public void accelerate(int kph) {
		_frontLeft.rotate(kph);
		_frontRight.rotate(kph);
	}
}

