package com.xpsurgery.carplanttests;

import static org.junit.Assert.assertEquals;
import org.junit.Before;
import org.junit.Test;
import java.io.StringWriter;
import com.xpsurgery.carplant.CarPlant;
import com.xpsurgery.carplant.Car;

public class ToyotaCorollaTest {

	private Car corolla;
  private StringWriter log;

	@Before
	public void setUp() throws Exception {
    log = new StringWriter();
		corolla = CarPlant.makeToyotaCorolla(log);
	}

	@Test
	public void hasTheCorrectName() {
		assertEquals("Toyota Corolla", corolla.name());
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
	public void acceleratingOnlyTurnsTheFrontWheels() {
		int speed = TestHelpers.randomSpeed();
		corolla.accelerate(speed);
		assertEquals("front left accelerating " + speed + " kph\n"
				   + "front right accelerating " + speed + " kph\n", log.toString());
	}

}

