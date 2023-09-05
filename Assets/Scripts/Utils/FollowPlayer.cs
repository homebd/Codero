using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    private Vector3 _offset;

    private void Start() {
        _offset = transform.position;
    }

    private void LateUpdate() {
        if (Player != null)
        {
            transform.position = _offset + Player.position;
        }
    }
}
