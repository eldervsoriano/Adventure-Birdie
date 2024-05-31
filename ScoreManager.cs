using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreTxt;
    
    public void AddScore(int score)
    {
        totalScore += score;
        scoreTxt.text = totalScore.ToString();
    }

}
