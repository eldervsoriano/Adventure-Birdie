using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionObstacle : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            collision.transform.SetParent(this.transform);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Player"))
        {
            collision.transform.SetParent(null);
        }
    }

}
