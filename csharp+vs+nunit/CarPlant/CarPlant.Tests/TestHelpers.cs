using System;

namespace CarPlant
{
	public class TestHelpers
	{
		private static Random rand = new Random();

		public static int randomDegrees()
		{
			return rand.Next(50) + 1;
		}

		public static int randomSpeed()
		{
			return rand.Next(80) + 5;
		}

	}
}