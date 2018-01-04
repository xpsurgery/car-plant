from wheel import Wheel

class Car:

    def __init__(self, log):
        self._frontLeft = Wheel("front left", log)
        self._frontRight = Wheel("front right", log)
        self._rearLeft = Wheel("rear left", log)
        self._rearRight = Wheel("rear right", log)

    def turnLeft(self, degrees):
        self._frontLeft.turnLeft(degrees)
        self._frontRight.turnLeft(degrees)

    def turnRight(self, degrees):
        self._frontLeft.turnRight(degrees)
        self._frontRight.turnRight(degrees)

