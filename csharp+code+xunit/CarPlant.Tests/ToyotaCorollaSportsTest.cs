using System;
using Xunit;

namespace CarPlant
{
	[Collection("Car plant")]
	public class ToyotaCorollaSportsTest
	{

		private Car corolla;

		public ToyotaCorollaSportsTest()
		{
			CarPlant.LOG = "";
			corolla = CarPlant.makeToyotaCorollaSports();
		}

		[Fact]
		public void HasTheCorrectName()
		{
			Assert.Equal("Toyota Corolla sports", corolla.Name());
		}

		[Fact]
		public void TurningLeftOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			corolla.TurnLeft(degrees);
			Assert.Equal("front left turning left " + degrees + " degrees\n"
			             + "front right turning left " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Fact]
		public void TurningRightOnlyTurnsTheFrontWheels()
		{
			int degrees = TestHelpers.randomDegrees();
			corolla.TurnRight(degrees);
			Assert.Equal("front left turning right " + degrees + " degrees\n"
			             + "front right turning right " + degrees + " degrees\n", CarPlant.LOG);
		}

		[Fact]
		public void AcceleratingOnlyTurnsTheRearWheels()
		{
			int speed = TestHelpers.randomSpeed();
			corolla.Accelerate(speed);
			Assert.Equal("rear left accelerating " + speed + " kph\n"
			             + "rear right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}
}

