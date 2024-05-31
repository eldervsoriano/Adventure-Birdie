using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ChampionButton : MonoBehaviour
{
    public new TextMeshProUGUI name;
    public TextMeshProUGUI level;

    public void SetData(string name, int level)
    {
        this.name.text = name;
        this.level.text = level.ToString();
    }
    public void SetData(Champion champion)
    {
        this.name.text = champion.name;
        this.level.text = champion.level.ToString();
    }
}
