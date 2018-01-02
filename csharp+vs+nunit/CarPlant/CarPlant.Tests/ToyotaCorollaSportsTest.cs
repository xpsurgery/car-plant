using NUnit.Framework;
using System;

namespace CarPlant
{
	[TestFixture]
	public class ToyotaCorollaSportsTest
	{

		private Car corolla;

		[SetUp]
		public void Init()
		{
			CarPlant.LOG = "";
			corolla = CarPlant.makeToyotaCorollaSports();
		}

		[Test]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Toyota Corolla sports", corolla.Name());
		}

		[Test]
		public void TurningLeftOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			corolla.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Test]
		public void TurningRightOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			corolla.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Test]
		public void AcceleratingOnlyTurnsTheRearWheels()
		{
			int speed = TestHelpers.randomSpeed();
			corolla.Accelerate(speed);
			Assert.AreEqual("rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}
}

