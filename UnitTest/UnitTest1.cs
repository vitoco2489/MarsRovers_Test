using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRovers_VE;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMoveLeft()
        {
            //This Test validate if we Set the rover on N we should point to E
            MarsRovers marsRovers = new MarsRovers("1 2 N");
            marsRovers.MoveLeft();
            Assert.AreEqual("W", marsRovers.Cardinalpoint);
        }
        [TestMethod]
        public void TestMoveRight()
        {
            //This Test validate if we Set the rover on N we should point to E
            MarsRovers marsRovers = new MarsRovers("1 2 N");
            marsRovers.MoveRight();
            Assert.AreEqual("E", marsRovers.Cardinalpoint);
        }
        [TestMethod]
        public void TestMoveForward()
        {
            //This test represent if we move forward setting the point on N we should increase yPosition
            MarsRovers marsRovers = new MarsRovers("1 2 N");
            marsRovers.MoveForward();
            Assert.AreEqual(3, marsRovers.yPosition);
        }
        [TestMethod]
        public void TestCommand_FirstRover_Output()
        {
            //Failed Commands
            //MarsRovers marsRovers = new MarsRovers("1 2 W");
            MarsRovers marsRovers = new MarsRovers("1 2 N");
            marsRovers.SendCommandRovers("LMLMLMLMM");
            Assert.AreEqual("1 3 N", string.Format("{0} {1} {2}", marsRovers.xPosition, marsRovers.yPosition, marsRovers.Cardinalpoint));
        }


    }
}
