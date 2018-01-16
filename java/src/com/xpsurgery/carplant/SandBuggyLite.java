package com.xpsurgery.carplant;

import java.io.Writer;

class SandBuggyLite extends RearWheelDriveCar {

  SandBuggyLite(Writer listener) {
      super(listener);
  }

	@Override
	public String name() {
		return "Sand Buggy Lite";
	}

}

