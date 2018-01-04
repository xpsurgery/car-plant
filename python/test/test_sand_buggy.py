import unittest
from helpers import TestHelpers
from car_plant import CarPlant

class SandBuggyTest(unittest.TestCase):

    def setUp(self):
        CarPlant.log = []
        self.buggy = CarPlant.makeSandBuggy()

    def testHasTheCorrectName(self):
        self.assertEquals("Sand Buggy", self.buggy.name())

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

    def testAcceleratingTurnsAllWheels(self):
        speed = TestHelpers.randomSpeed()
        self.buggy.accelerate(speed)
        self.assertEquals("front left accelerating " + str(speed) + " kph\n"
                   + "front right accelerating " + str(speed) + " kph\n"
                   + "rear left accelerating " + str(speed) + " kph\n"
                   + "rear right accelerating " + str(speed) + " kph\n", ''.join(CarPlant.log))


