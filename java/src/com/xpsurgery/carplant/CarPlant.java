package com.xpsurgery.carplant;

import java.io.Writer;

public class CarPlant {

	public static Car makeToyotaCorolla(Writer listener) {
		return new ToyotaCorolla(listener);
	}

	public static Car makeToyotaCorollaSports(Writer listener) {
		return new ToyotaCorollaSports(listener);
	}

	public static Car makeMitsubishiTriton(Writer listener) {
		return new MitsubishiTriton(listener);
	}

	public static Car makeSandBuggy(Writer listener) {
		return new SandBuggy(listener);
	}

	public static Car makeSandBuggyLite(Writer listener) {
		return new SandBuggyLite(listener);
	}
}

