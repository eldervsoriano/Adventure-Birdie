using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsObject : MonoBehaviour
{
    public AudioSource audioSource;
    
    public int score = 1;
    public AudioSource Pig;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Pig.Play();
        GameManager.instance.scoreManager.AddScore(score);
        Debug.Log("Score: " + GameManager.instance.scoreManager.totalScore);
        Destroy(this.gameObject, 0.4f);
        


    }
}
