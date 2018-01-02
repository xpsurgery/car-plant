namespace CarPlant {
	public abstract class FourWheelDriveCar : Car
	{
		public override void Accelerate(int kph)
		{
			_frontLeft.rotate(kph);
			_frontRight.rotate(kph);
			_rearLeft.rotate(kph);
			_rearRight.rotate(kph);
		}
	}
}