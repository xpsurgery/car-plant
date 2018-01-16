package com.xpsurgery.carplanttests;

import static org.junit.Assert.assertEquals;
import org.junit.Before;
import org.junit.Test;
import java.io.StringWriter;
import com.xpsurgery.carplant.CarPlant;
import com.xpsurgery.carplant.Car;

public class SandBuggyTest {

	private Car buggy;
  private StringWriter log;

	@Before
	public void setUp() throws Exception {
    log = new StringWriter();
		buggy = CarPlant.makeSandBuggy(log);
	}

	@Test
	public void hasTheCorrectName() {
		assertEquals("Sand Buggy", buggy.name());
	}

	@Test
	public void turningLeftTurnsAllWheels() {
		int degrees = TestHelpers.randomDegrees();
		buggy.turnLeft(degrees);
		assertEquals("front left turning left " + degrees + " degrees\n"
				   + "front right turning left " + degrees + " degrees\n"
				   + "rear left turning right " + degrees + " degrees\n"
				   + "rear right turning right " + degrees + " degrees\n", log.toString());
	}

	@Test
	public void turningRightTurnsAllWheels() {
		int degrees = TestHelpers.randomDegrees();
		buggy.turnRight(degrees);
		assertEquals("front left turning right " + degrees + " degrees\n"
				   + "front right turning right " + degrees + " degrees\n"
				   + "rear left turning left " + degrees + " degrees\n"
				   + "rear right turning left " + degrees + " degrees\n", log.toString());
	}

	@Test
	public void acceleratingTurnsAllWheels() {
		int speed = TestHelpers.randomSpeed();
		buggy.accelerate(speed);
		assertEquals("front left accelerating " + speed + " kph\n"
				   + "front right accelerating " + speed + " kph\n"
				   + "rear left accelerating " + speed + " kph\n"
				   + "rear right accelerating " + speed + " kph\n", log.toString());
	}

}

