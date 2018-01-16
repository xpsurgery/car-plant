package com.xpsurgery.carplanttests;

import static org.junit.Assert.assertEquals;
import org.junit.Before;
import org.junit.Test;
import java.io.StringWriter;
import com.xpsurgery.carplant.CarPlant;
import com.xpsurgery.carplant.Car;

public class ToyotaCorollaSportsTest {

	private Car corolla;
  private StringWriter log;

	@Before
	public void setUp() throws Exception {
    log = new StringWriter();
		corolla = CarPlant.makeToyotaCorollaSports(log);
	}

	@Test
	public void hasTheCorrectName() {
		assertEquals("Toyota Corolla sports", corolla.name());
	}

	@Test
	public void turningLeftOnlyTurnsTheFrontWheels() {
		int degrees = TestHelpers.randomDegrees();
		corolla.turnLeft(degrees);
		assertEquals("front left turning left " + degrees + " degrees\n"
				   + "front right turning left " + degrees + " degrees\n", log.toString());
	}

	@Test
	public void turningRightOnlyTurnsTheFrontWheels() {
		int degrees = TestHelpers.randomDegrees();
		corolla.turnRight(degrees);
		assertEquals("front left turning right " + degrees + " degrees\n"
				   + "front right turning right " + degrees + " degrees\n", log.toString());
	}

	@Test
	public void acceleratingOnlyTurnsTheRearWheels() {
		int speed = TestHelpers.randomSpeed();
		corolla.accelerate(speed);
		assertEquals("rear left accelerating " + speed + " kph\n"
				   + "rear right accelerating " + speed + " kph\n", log.toString());
	}

}

