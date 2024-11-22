using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests.Play_Mode
{
    public class MoveTests
    {
        [UnityTest]
        public IEnumerator MoveTestUp()
        {
            // New GameObject
            var testGameObject = new GameObject();
        
            // Test player unit
            var testPlayerUnit = testGameObject.AddComponent<Unit>();
        
            // Set the player unit's position
            testPlayerUnit.transform.position = new Vector3(0, 0, 0);
        
            // Set player movement speed
            testPlayerUnit.SetMoveSpeed(1f);
        
            // Move the player unit up
            testPlayerUnit.MoveUp();
        
            // Wait for 1s
            yield return new WaitForSeconds(1);
        
            // Check if the player unit's position is correct
            Assert.AreEqual(new Vector3(0, 1, 0), testPlayerUnit.transform.position);
        }
    
        [UnityTest]
        public IEnumerator MoveTestDown()
        {
            // New GameObject
            var testGameObject = new GameObject();
        
            // Test player unit
            var testPlayerUnit = testGameObject.AddComponent<Unit>();
        
            // Set the player unit's position
            testPlayerUnit.transform.position = new Vector3(0, 0, 0);
        
            // Set player movement speed
            testPlayerUnit.SetMoveSpeed(1f);
        
            // Move the player unit down
            testPlayerUnit.MoveDown();
        
            // Wait for 1s
            yield return new WaitForSeconds(1);
        
            // Check if the player unit's position is correct
            Assert.AreEqual(new Vector3(0, -1, 0), testPlayerUnit.transform.position);
        }
    
        [UnityTest]
        public IEnumerator MoveTestLeft()
        {
            // New GameObject
            var testGameObject = new GameObject();
        
            // Test player unit
            var testPlayerUnit = testGameObject.AddComponent<Unit>();
        
            // Set the player unit's position
            testPlayerUnit.transform.position = new Vector3(0, 0, 0);
        
            // Set player movement speed
            testPlayerUnit.SetMoveSpeed(1f);
        
            // Move the player unit left
            testPlayerUnit.MoveLeft();
        
            // Wait for 1s
            yield return new WaitForSeconds(1);
        
            // Check if the player unit's position is correct
            Assert.AreEqual(new Vector3(-1, 0, 0), testPlayerUnit.transform.position);
        }
    
        [UnityTest]
        public IEnumerator MoveTestRight()
        {
            // New GameObject
            var testGameObject = new GameObject();
        
            // Test player unit
            var testPlayerUnit = testGameObject.AddComponent<Unit>();
        
            // Set the player unit's position
            testPlayerUnit.transform.position = new Vector3(0, 0, 0);
        
            // Set player movement speed
            testPlayerUnit.SetMoveSpeed(1f);
        
            // Move the player unit right
            testPlayerUnit.MoveRight();
        
            // Wait for 1s
            yield return new WaitForSeconds(1);
        
            // Check if the player unit's position is correct
            Assert.AreEqual(new Vector3(1, 0, 0), testPlayerUnit.transform.position);
        }
    }
}
