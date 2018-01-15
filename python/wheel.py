class Wheel:

    def __init__(self, name, listener):
        self.name = name
        self.listener = listener

    def turnLeft(self, degrees):
        self.listener.append(self.name + " turning left " + str(degrees) + " degrees\n")

    def turnRight(self, degrees):
        self.listener.append(self.name + " turning right " + str(degrees) + " degrees\n")

    def rotate(self, kph):
        self.listener.append(self.name + " accelerating " + str(kph) + " kph\n")

