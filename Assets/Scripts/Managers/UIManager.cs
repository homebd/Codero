using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    public string InputName { get; set; }
    public Sprite PlayerSprite;
    public GameObject Panel;

    public UIManager() {
        InputName = "";
    }
}
