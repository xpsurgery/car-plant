namespace CarPlant
{
	abstract class FrontWheelDriveCar : Car
	{
		public override void Accelerate(int kph)
		{
			_frontLeft.rotate(kph);
			_frontRight.rotate(kph);
		}
	}
}