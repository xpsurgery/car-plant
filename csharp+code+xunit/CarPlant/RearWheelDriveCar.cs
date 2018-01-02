namespace CarPlant
{
	public abstract class RearWheelDriveCar : Car
	{
		public override void Accelerate(int kph)
		{
			_rearLeft.rotate(kph);
			_rearRight.rotate(kph);
		}
	}
}