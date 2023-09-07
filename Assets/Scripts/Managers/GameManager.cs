using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public string PlayerName { get; set; }
    public PlayerType Player { get; set; }

    public void ChangePlayerName(string name) {
        PlayerName = name;
    }
}
