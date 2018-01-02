namespace CarPlant {

	public class Wheel {

		private string name;

		public Wheel(string name) {
			this.name = name;
		}

		public void turnLeft(int degrees) {
			CarPlant.LOG += name + " turning left " + degrees + " degrees\n";
		}

		public void turnRight(int degrees) {
			CarPlant.LOG += name + " turning right " + degrees + " degrees\n";
		}

		public void rotate(int kph) {
			CarPlant.LOG += name + " accelerating " + kph + " kph\n";
		}

	}
}