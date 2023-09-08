using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public enum InfoType { StatC, StatD, StatA, StatS, Name}

    public InfoType Type;
    Text text;

    void Awake() {
        text = GetComponent<Text>();
    }
    void LateUpdate() {
        switch(Type) {
            case InfoType.StatC:
                text.text = $"{Managers.GameManager.PlayerStat[0]}";
                break;
            case InfoType.StatD:
                text.text = $"{Managers.GameManager.PlayerStat[1]}";
                break;
            case InfoType.StatA:
                text.text = $"{Managers.GameManager.PlayerStat[2]}";
                break;
            case InfoType.StatS:
                text.text = $"{Managers.GameManager.PlayerStat[3]}";
                break;
            case InfoType.Name:
                text.text = $"{Managers.GameManager.PlayerName}";
                break;
            

        }
    }
    
}
