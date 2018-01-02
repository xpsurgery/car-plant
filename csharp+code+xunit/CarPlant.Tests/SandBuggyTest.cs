using System;
using Xunit;

namespace CarPlant
{
	[Collection("Car plant")]
	public class SandBuggyTest
	{
		private Car buggy;

		public SandBuggyTest()
		{
			CarPlant.LOG = "";
			buggy = CarPlant.makeSandBuggy();
		}

		[Fact]
		public void HasTheCorrectName()
		{
			Assert.Equal("Sand Buggy", buggy.Name());
		}

		[Fact]
		public void TurningLeftTurnsAllWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			buggy.TurnLeft(degrees);
			Assert.Equal("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n"
			             + "rear left turning right " + degrees + " degrees\n"
			             + "rear right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Fact]
		public void TurningRightTurnsAllWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			buggy.TurnRight(degrees);
			Assert.Equal("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n"
			             + "rear left turning left " + degrees + " degrees\n"
			             + "rear right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Fact]
		public void AcceleratingTurnsAllWheels()
		{
			int speed = TestHelpers.randomSpeed();
			buggy.Accelerate(speed);
			Assert.Equal("front left accelerating " + speed + " kph\n"
			             + "front right accelerating " + speed + " kph\n"
			             + "rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}
}

