using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChampionView : MonoBehaviour
{
    public TextMeshProUGUI attackTxt;
    public TextMeshProUGUI healthTxt;
    public void ShowData(Champion champion)
    {
        attackTxt.text = "Attack: " + champion.attackDamage.ToString();
        healthTxt.text = "Health: " + champion.health.ToString();
    }
}
 