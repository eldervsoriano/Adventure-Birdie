using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChampionManager : MonoBehaviour
{
    public Champion[] champions;
    public Transform parentPos;
    private string folderPath = "Champions"; // Assets/Resources/Champions

    void Awake()
    {
        champions = Resources.LoadAll<Champion>(folderPath);
    }
}
