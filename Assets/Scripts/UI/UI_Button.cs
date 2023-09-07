using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    public Button Button;
    private void Update() {
        if(Managers.UIManager.InputName.Length >= 2)
            Button.interactable = true;
        else
            Button.interactable = false;
    }

    public void ClickJoinButton() {
        // 입력받은 이름 가져옴
        string name = Managers.UIManager.InputName;

        // 플레이어 이름 등록
        Managers.GameManager.ChangePlayerName(name);

        SceneManager.LoadScene("MainScene");
    }
}
