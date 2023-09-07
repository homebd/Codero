using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Image : MonoBehaviour
{
    public GameObject Panel;

    private Image _image;

    private void Start() {
        _image = gameObject.GetComponent<Image>();
    }
    
    private void Update() {
        if(Managers.UIManager.PlayerSprite != null) {
            _image.sprite = Managers.UIManager.PlayerSprite;
        }
    }

    public void ShowPanel() {
        Panel.SetActive(true);
    }
}
