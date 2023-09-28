using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class PlayerJumpTests
{
    [UnityTest]
    public IEnumerator PlayerJumpTestsInSceneSimpleJump()
    {
        // ARRANGE
        SceneManager.LoadScene("Assets/Scenes/GameScene.unity");
        yield return new WaitForSeconds(1f);
        GameObject tempGameObject = GameObject.Find("Player");
        PlayerJump playerjump = tempGameObject.GetComponentInChildren<PlayerJump>();
        Rigidbody rb = tempGameObject.GetComponent<Rigidbody>();
        float InitialPosY= rb.position.y;
        // ACT

        playerjump.Jump();
        yield return new WaitForSeconds(0.2f);


        // ASSERT
        Assert.IsTrue(rb.velocity.y != 0f);
        Assert.IsTrue(rb.position.y > InitialPosY);
    }

}
