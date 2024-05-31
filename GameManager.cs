using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Champion champion;
    public ChampionButton championButton;

    public ScoreManager scoreManager;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

    }
    public void GameOver()
    {
        Debug.Log("Skill Issue LOL");
    }
}
