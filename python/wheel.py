class Wheel:

    def __init__(self, name, log):
        self.name = name
        self.log = log

    def turnLeft(self, degrees):
        self.log.append(self.name + " turning left " + str(degrees) + " degrees\n")

    def turnRight(self, degrees):
        self.log.append(self.name + " turning right " + str(degrees) + " degrees\n")

    def rotate(self, kph):
        self.log.append(self.name + " accelerating " + str(kph) + " kph\n")

