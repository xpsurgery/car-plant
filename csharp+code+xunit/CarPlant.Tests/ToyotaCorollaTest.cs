using System;
using Xunit;

namespace CarPlant
{
	[Collection("Car plant")]
	public class ToyotaCorollaTest
	{

		private Car corolla;

		public ToyotaCorollaTest()
		{
			CarPlant.LOG = "";
			corolla = CarPlant.makeToyotaCorolla();
		}

		[Fact]
		public void HasTheCorrectName()
		{
			Assert.Equal("Toyota Corolla", corolla.Name());
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
		public void AcceleratingOnlyTurnsTheFrontWheels()
		{
			int speed = TestHelpers.randomSpeed();
			corolla.Accelerate(speed);
			Assert.Equal("front left accelerating " + speed + " kph\n"
			              + "front right accelerating " + speed + " kph\n", CarPlant.LOG);
		}

	}

}
