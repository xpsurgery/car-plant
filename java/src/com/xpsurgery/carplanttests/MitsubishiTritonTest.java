package com.xpsurgery.carplanttests;

import static org.junit.Assert.assertEquals;
import org.junit.Before;
import org.junit.Test;
import java.io.StringWriter;
import com.xpsurgery.carplant.CarPlant;
import com.xpsurgery.carplant.Car;

public class MitsubishiTritonTest {

	private Car triton;
  private StringWriter log;

	@Before
	public void setUp() throws Exception {
    log = new StringWriter();
		triton = CarPlant.makeMitsubishiTriton(log);
	}

	@Test
	public void hasTheCorrectName() {
		assertEquals("Mitsubishi Triton", triton.name());
	}

	@Test
	public void turningLeftOnlyTurnsTheFrontWheels() {
		int degrees = TestHelpers.randomDegrees();
		triton.turnLeft(degrees);
		assertEquals("front left turning left " + degrees + " degrees\n"
				   + "front right turning left " + degrees + " degrees\n", log.toString());
	}

	@Test
	public void turningRightOnlyTurnsTheFrontWheels() {
		int degrees = TestHelpers.randomDegrees();
		triton.turnRight(degrees);
		assertEquals("front left turning right " + degrees + " degrees\n"
				   + "front right turning right " + degrees + " degrees\n", log.toString());
	}

	@Test
	public void acceleratingTurnsAllWheels() {
		int speed = TestHelpers.randomSpeed();
		triton.accelerate(speed);
		assertEquals("front left accelerating " + speed + " kph\n"
				   + "front right accelerating " + speed + " kph\n"
				   + "rear left accelerating " + speed + " kph\n"
				   + "rear right accelerating " + speed + " kph\n", log.toString());
	}

}

