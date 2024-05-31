using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform targetPos;
    public bool isRange;
    public Transform playerPos;
    public AudioSource Swoosh;

    public void Update()
    {
        //
        Swoosh.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isRange = true;

            if (playerPos == null)
            {
                playerPos = collision.GetComponent<Transform>();
                playerPos.position = targetPos.position;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isRange = false;
        }
    }
}
