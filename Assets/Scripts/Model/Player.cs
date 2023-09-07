using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    public Text NameText;
    public List<GameObject> Sprite;

    private void Awake() {
        Instantiate(Sprite[(int)Managers.GameManager.Player], transform);
        NameText.text = Managers.GameManager.PlayerName;
    }
}
