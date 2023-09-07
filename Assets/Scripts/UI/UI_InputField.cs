using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_InputField : MonoBehaviour
{
    public Text InputText;

    // Update is called once per frame
    void Update()
    {
        // 바뀔 떄마다 현재 Input 등록
        Managers.UIManager.InputName = InputText.text;
    }
}
