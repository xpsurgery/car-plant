using NUnit.Framework;
using System;

namespace CarPlant
{
	[TestFixture]
	public class SandBuggyLiteTest
	{
		private Car buggy;

		[SetUp]
		public void Init()
		{
			CarPlant.LOG = "";
			buggy = CarPlant.makeSandBuggyLite();
		}

		[Test]
		public void HasTheCorrectName()
		{
			Assert.AreEqual("Sand Buggy Lite", buggy.Name());
		}

		[Test]
		public void TurningLeftTurnsAllWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			buggy.TurnLeft(degrees);
			Assert.AreEqual("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n"
			             + "rear left turning right " + degrees + " degrees\n"
			             + "rear right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Test]
		public void TurningRightTurnsAllWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			buggy.TurnRight(degrees);
			Assert.AreEqual("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n"
			             + "rear left turning left " + degrees + " degrees\n"
			             + "rear right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Test]
		public void AcceleratingTurnsOnlyTheRearWheels()
		{
			int speed = TestHelpers.randomSpeed();
			buggy.Accelerate(speed);
			Assert.AreEqual("rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}
}

