using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : Character
{
    public List<GameObject> Sprite;

    private void Awake() {
        // (성별에 따라) 스프라이트 생성
        GameObject go = Instantiate(Sprite[(int)Managers.GameManager.Player], transform);

        // 스프라이트에 따라 애니메이터 할당
        Animator anim = go.GetComponent<Animator>();
        gameObject.GetComponent<Movement>().Anim = anim;
        
        // 스프라이트에 따라 렌더러 할당
        SpriteRenderer sprite = go.GetComponent<SpriteRenderer>();
        gameObject.GetComponent<Movement>().Sprite = sprite;
    }
}
