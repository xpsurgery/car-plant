from car import Car

class FourWheelDriveCar(Car):

    def accelerate(self, kph):
        self._frontLeft.rotate(kph)
        self._frontRight.rotate(kph)
        self._rearLeft.rotate(kph)
        self._rearRight.rotate(kph)

