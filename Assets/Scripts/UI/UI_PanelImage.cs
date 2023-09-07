using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_PanelImage : MonoBehaviour
{
    public GameObject Panel;
    public PlayerType player;

    public void SelectCharacter() {
        // 메뉴씬에 보이는 플레이어 이미지 변경
        Managers.UIManager.PlayerSprite = gameObject.GetComponent<Image>().sprite;
        
        // 실제 조작할 플레이어를 변경하기 위해 enum 설정
        Managers.GameManager.Player = player;
        Panel.SetActive(false);
    }
}
