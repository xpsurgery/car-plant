from mitsubishi_triton import MitsubishiTriton
from toyota_corolla import ToyotaCorolla
from toyota_corolla_sports import ToyotaCorollaSports
from sand_buggy import SandBuggy
from sand_buggy_lite import SandBuggyLite

class CarPlant:

    log = []

    @staticmethod
    def makeToyotaCorolla():
        return ToyotaCorolla(CarPlant.log)

    @staticmethod
    def makeToyotaCorollaSports():
        return ToyotaCorollaSports(CarPlant.log)

    @staticmethod
    def makeMitsubishiTriton():
        return MitsubishiTriton(CarPlant.log)

    @staticmethod
    def makeSandBuggy():
        return SandBuggy(CarPlant.log)

    @staticmethod
    def makeSandBuggyLite():
        return SandBuggyLite(CarPlant.log)

