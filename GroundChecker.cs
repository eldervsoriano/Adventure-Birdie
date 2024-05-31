using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GroundChecker : MonoBehaviour
{
    public PlayerController controller;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            controller.isGrounded = true;
        }
    }
}
    