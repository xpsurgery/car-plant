from car import Car

class RearWheelDriveCar(Car):

    def accelerate(self, kph):
        self._rearLeft.rotate(kph)
        self._rearRight.rotate(kph)

