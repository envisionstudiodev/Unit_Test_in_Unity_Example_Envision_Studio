using NUnit.Framework;
using UnityEngine;

namespace Tests.Edit_Mode
{
    public class DirectionTest
    {
        [Test]
        public void DirectionTestUp()
        {
            // Check if the Direction.Up is correct
            Assert.AreEqual(new Vector3(0, 1, 0), Direction.Up);
        }
        
        [Test]
        public void DirectionTestDown()
        {
            // Check if the Direction.Down is correct
            Assert.AreEqual(new Vector3(0, -1, 0), Direction.Down);
        }
        
        [Test]
        public void DirectionTestLeft()
        {
            // Check if the Direction.Left is correct
            Assert.AreEqual(new Vector3(-1, 0, 0), Direction.Left);
        }
        
        [Test]
        public void DirectionTestRight()
        {
            // Check if the Direction.Right is correct
            Assert.AreEqual(new Vector3(1, 0, 0), Direction.Right);
        }
    }
}
