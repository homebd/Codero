using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public string PlayerName { get; set; }
    public PlayerType Player { get; set; }
    public int[] PlayerStat { get; set; }

    public GameManager() {
        PlayerName = "";
        Player = PlayerType.BOY;
        PlayerStat = new int[4]; // 스탯의 종류
    }

    public void ChangePlayerName(string name) {
        PlayerName = name;
    }
}
