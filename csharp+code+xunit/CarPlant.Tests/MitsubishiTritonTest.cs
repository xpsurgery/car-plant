using System;
using Xunit;

namespace CarPlant
{
	[Collection("Car plant")]
	public class MitsubishiTritonTest
	{
		private Car triton;

		public MitsubishiTritonTest()
		{
			CarPlant.LOG = "";
			triton = CarPlant.makeMitsubishiTriton();
		}

		[Fact]
		public void HasTheCorrectName()
		{
			Assert.Equal("Mitsubishi Triton", triton.Name());
		}

		[Fact]
		public void TurningLeftOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			triton.TurnLeft(degrees);
			Assert.Equal("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Fact]
		public void TurningRightOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			triton.TurnRight(degrees);
			Assert.Equal("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Fact]
		public void AcceleratingTurnsAllWheels()
		{
			int speed = TestHelpers.randomSpeed();
			triton.Accelerate(speed);
			Assert.Equal("front left accelerating " + speed + " kph\n"
			             + "front right accelerating " + speed + " kph\n"
			             + "rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}
}

