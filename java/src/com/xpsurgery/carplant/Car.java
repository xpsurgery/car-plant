package com.xpsurgery.carplant;

import java.io.Writer;

public abstract class Car {

	public Wheel _frontLeft;
	public Wheel _frontRight;
	public Wheel _rearLeft;
	public Wheel _rearRight;

	public abstract String name();
	public abstract void accelerate(int kmsPerHour);

	protected Car(Writer listener) {
		_frontLeft = new Wheel("front left", listener);
		_frontRight = new Wheel("front right", listener);
		_rearLeft = new Wheel("rear left", listener);
		_rearRight = new Wheel("rear right", listener);
	}

	public void turnLeft(int degrees) {
		_frontLeft.turnLeft(degrees);
		_frontRight.turnLeft(degrees);
	}

	public void turnRight(int degrees) {
		_frontLeft.turnRight(degrees);
		_frontRight.turnRight(degrees);
	}
}

