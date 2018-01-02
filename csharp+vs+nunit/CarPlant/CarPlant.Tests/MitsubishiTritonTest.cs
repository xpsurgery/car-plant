using NUnit.Framework;
using System;

namespace CarPlant
{
	[TestFixture]
	public class MitsubishiTritonTest
	{
		private Car triton;

		[SetUp]
		public void Init()
		{
			CarPlant.LOG = "";
			triton = CarPlant.makeMitsubishiTriton();
		}

		[Test]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Mitsubishi Triton", triton.Name());
		}

		[Test]
		public void TurningLeftOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			triton.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Test]
		public void TurningRightOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			triton.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Test]
		public void AcceleratingTurnsAllWheels()
		{
			int speed = TestHelpers.randomSpeed();
			triton.Accelerate(speed);
			Assert.AreEqual("front left accelerating " + speed + " kph\n"
			             + "front right accelerating " + speed + " kph\n"
			             + "rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}
}

