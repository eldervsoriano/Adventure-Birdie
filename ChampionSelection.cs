using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChampionSelection : MonoBehaviour
{
    public ChampionManager championManager; // Reference all scriptable object of Champions
    public Transform parentPos; // buttonHolder
    public GameObject championButtonPrefab;
    public ChampionView championView;
    
    void Start()
    {
        foreach (Champion c in championManager.champions)
        {
            GameObject buttonPrefab = Instantiate(championButtonPrefab, parentPos);
            ChampionButton championButton = buttonPrefab.GetComponent<ChampionButton>();
            championButton.SetData(c);
            Button button = buttonPrefab.GetComponent<Button>();
            button.onClick.AddListener(() => championView.ShowData(c));
            
        }
    }
}
