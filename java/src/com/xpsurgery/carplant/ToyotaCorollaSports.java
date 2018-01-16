package com.xpsurgery.carplant;

import java.io.Writer;

class ToyotaCorollaSports extends RearWheelDriveCar {

  ToyotaCorollaSports(Writer listener) {
    super(listener);
  }

	public String name() {
		return "Toyota Corolla sports";
	}
}

