using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerMovementTests
{
    // A Test behaves as an ordinary method
    [UnityTest]
    public IEnumerator PlayerMovementGoForward()
    {
        // ARRANGE
        GameObject tempGameObject = new GameObject();
        PlayerMovement playerMovement = tempGameObject.AddComponent<PlayerMovement>();  
        Rigidbody rb = tempGameObject.AddComponent<Rigidbody>();
        playerMovement.Initialize(rb);

        // ACT
        playerMovement.Move(new Vector2(1f, 0f));
        yield return new WaitForSeconds(0.2f);

        // ASSERT
        Assert.IsTrue(rb.velocity.x > 0f);
        Assert.IsTrue(rb.position.x > 0.05f);
    }

    
}
