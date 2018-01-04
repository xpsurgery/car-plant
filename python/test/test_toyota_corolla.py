import unittest
from helpers import TestHelpers
from car_plant import CarPlant

class ToyotaCorollaTest(unittest.TestCase):

    def setUp(self):
        CarPlant.log = []
        self.corolla = CarPlant.makeToyotaCorolla()

    def testHasTheCorrectName(self):
        self.assertEquals("Toyota Corolla", self.corolla.name())

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

    def testAcceleratingOnlyTurnsTheFrontWheels(self):
        speed = TestHelpers.randomSpeed()
        self.corolla.accelerate(speed)
        self.assertEquals("front left accelerating " + str(speed) + " kph\n"
                   + "front right accelerating " + str(speed) + " kph\n", ''.join(CarPlant.log))

