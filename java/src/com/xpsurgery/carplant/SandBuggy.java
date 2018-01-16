package com.xpsurgery.carplant;

import java.io.Writer;

class SandBuggy extends FourWheelDriveCar {

  SandBuggy(Writer listener) {
    super(listener);
  }


	@Override
	public String name() {
		return "Sand Buggy";
	}
}

