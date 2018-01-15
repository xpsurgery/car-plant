package com.xpsurgery.carplant;

class Wheel {

	private String name;

	Wheel(String name) {
		this.name = name;
	}

	void turnLeft(int degrees) {
		CarPlant.LOG += name + " turning left " + degrees + " degrees\n";
	}

	void turnRight(int degrees) {
		CarPlant.LOG += name + " turning right " + degrees + " degrees\n";
	}

	void rotate(int kph) {
		CarPlant.LOG += name + " accelerating " + kph + " kph\n";
	}

}

