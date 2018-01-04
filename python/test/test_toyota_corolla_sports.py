import unittest
from helpers import TestHelpers
from car_plant import CarPlant

class ToyotaCorollaSportsTest(unittest.TestCase):

    def setUp(self):
        CarPlant.log = []
        self.corolla = CarPlant.makeToyotaCorollaSports()

    def testHasTheCorrectName(self):
        self.assertEquals("Toyota Corolla sports", self.corolla.name())

    def testTurningLeftOnlyTurnsTheFrontWheels(self):
        degrees = TestHelpers.randomDegrees()
        self.corolla.turnLeft(degrees)
        self.assertEquals("front left turning left " + str(degrees) + " degrees\n"
                   + "front right turning left " + str(degrees) + " degrees\n", ''.join(CarPlant.log))

    def testTurningRightOnlyTurnsTheFrontWheels(self):
        degrees = TestHelpers.randomDegrees()
        self.corolla.turnRight(degrees)
        self.assertEquals("front left turning right " + str(degrees) + " degrees\n"
                   + "front right turning right " + str(degrees) + " degrees\n", ''.join(CarPlant.log))

    def testAcceleratingOnlyTurnsTheRearWheels(self):
        speed = TestHelpers.randomSpeed()
        self.corolla.accelerate(speed)
        self.assertEquals("rear left accelerating " + str(speed) + " kph\n"
                   + "rear right accelerating " + str(speed) + " kph\n", ''.join(CarPlant.log))

