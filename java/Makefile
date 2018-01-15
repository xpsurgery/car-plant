SOURCES   := $(wildcard src/com/xpsurgery/*/*.java)
JFLAGS    := -g
JAVA      := java
JAVAC     := javac
CLASSPATH := -classpath src:junit-4.12.jar:hamcrest-core-1.3.jar

.SUFFIXES: .java .class

.java.class:
	$(JAVAC) $(JFLAGS) $(CLASSPATH) $*.java

.PHONY: test run clean clobber

test: $(SOURCES:.java=.class)
	$(JAVA) -cp src:junit-4.12.jar:hamcrest-core-1.3.jar org.junit.runner.JUnitCore com.xpsurgery.carplanttests.CarPlantTests

clean:
	$(RM) **/*.class

clobber: clean

