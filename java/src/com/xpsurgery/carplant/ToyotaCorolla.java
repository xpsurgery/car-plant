package com.xpsurgery.carplant;

import java.io.Writer;

class ToyotaCorolla extends FrontWheelDriveCar {

  ToyotaCorolla(Writer listener) {
    super(listener);
  }

	public String name() {
		return "Toyota Corolla";
	}
}

