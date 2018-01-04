from car import Car

class FrontWheelDriveCar(Car):

    def accelerate(self, kph):
        self._frontLeft.rotate(kph)
        self._frontRight.rotate(kph)

