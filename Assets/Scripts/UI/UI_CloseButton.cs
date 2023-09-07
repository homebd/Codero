using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_CloseButton : MonoBehaviour
{
    public Button Button;

    public void ClosePanel() {
        Transform panelTransform = Button.transform.parent.parent;

        if (panelTransform != null)
        {
            panelTransform.gameObject.SetActive(false);
        }
    }
}
