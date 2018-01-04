import unittest
from helpers import TestHelpers
from car_plant import CarPlant

class MitsubishiTritonTest(unittest.TestCase):

    def setUp(self):
        CarPlant.log = []
        self.triton = CarPlant.makeMitsubishiTriton()

    def testHasTheCorrectName(self):
        self.assertEquals("Mitsubishi Triton", self.triton.name())

    def testTurningLeftOnlyTurnsTheFrontWheels(self):
        degrees = TestHelpers.randomDegrees()
        self.triton.turnLeft(degrees)
        self.assertEquals("front left turning left " + str(degrees) + " degrees\n"
                   + "front right turning left " + str(degrees) + " degrees\n", ''.join(CarPlant.log))

    def testTurningRightOnlyTurnsTheFrontWheels(self):
        degrees = TestHelpers.randomDegrees()
        self.triton.turnRight(degrees)
        self.assertEquals("front left turning right " + str(degrees) + " degrees\n"
                   + "front right turning right " + str(degrees) + " degrees\n", ''.join(CarPlant.log))

    def testAcceleratingTurnsAllWheels(self):
        speed = TestHelpers.randomSpeed()
        self.triton.accelerate(speed)
        self.assertEquals("front left accelerating " + str(speed) + " kph\n"
                   + "front right accelerating " + str(speed) + " kph\n"
                   + "rear left accelerating " + str(speed) + " kph\n"
                   + "rear right accelerating " + str(speed) + " kph\n", ''.join(CarPlant.log))

