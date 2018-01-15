package com.xpsurgery.carplanttests;

import org.junit.runner.RunWith;
import org.junit.runners.Suite;
import org.junit.runners.Suite.SuiteClasses;

@RunWith(Suite.class)
@SuiteClasses({
  com.xpsurgery.carplanttests.MitsubishiTritonTest.class,
  com.xpsurgery.carplanttests.SandBuggyTest.class,
  com.xpsurgery.carplanttests.SandBuggyLiteTest.class,
  com.xpsurgery.carplanttests.ToyotaCorollaTest.class,
  com.xpsurgery.carplanttests.ToyotaCorollaSportsTest.class
})
public final class CarPlantTests {
}

