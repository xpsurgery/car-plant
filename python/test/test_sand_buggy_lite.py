import unittest
from helpers import TestHelpers
from car_plant import CarPlant

class SandBuggyLiteTest(unittest.TestCase):

    def setUp(self):
        CarPlant.log = []
        self.buggy = CarPlant.makeSandBuggyLite()

    def testHasTheCorrectName(self):
        self.assertEquals("Sand Buggy Lite", self.buggy.name())

    def testTurningLeftTurnsAllWheels(self):
        degrees = TestHelpers.randomDegrees()
        self.buggy.turnLeft(degrees)
        self.assertEquals("front left turning left " + str(degrees) + " degrees\n"
                   + "front right turning left " + str(degrees) + " degrees\n"
                   + "rear left turning right " + str(degrees) + " degrees\n"
                   + "rear right turning right " + str(degrees) + " degrees\n", ''.join(CarPlant.log))

    def testTurningRightTurnsAllWheels(self):
        degrees = TestHelpers.randomDegrees()
        self.buggy.turnRight(degrees)
        self.assertEquals("front left turning right " + str(degrees) + " degrees\n"
                   + "front right turning right " + str(degrees) + " degrees\n"
                   + "rear left turning left " + str(degrees) + " degrees\n"
                   + "rear right turning left " + str(degrees) + " degrees\n", ''.join(CarPlant.log))

    def testAcceleratingTurnsOnlyTheRearWheels(self):
        speed = TestHelpers.randomSpeed()
        self.buggy.accelerate(speed)
        self.assertEquals("rear left accelerating " + str(speed) + " kph\n"
                   + "rear right accelerating " + str(speed) + " kph\n", ''.join(CarPlant.log))


