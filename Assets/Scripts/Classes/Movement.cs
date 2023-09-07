using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    [HideInInspector] public Animator Anim;
    [HideInInspector] public SpriteRenderer Sprite;
    [SerializeField] private float _speed;
    [SerializeField] private float _runBonus;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        // 방향에 맞게 회전
        if(direction != Vector2.zero) {
            float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            if(Mathf.Abs(rotZ) != 90f) {
                Sprite.flipX = Mathf.Abs(rotZ) < 90f;
            }
            
        }

        
        // 방향 * 속도
        direction = direction * _speed * _runBonus;
        if(_controller.IsRunning) {
            direction *= _runBonus;
        }

        _rigidbody.velocity = direction;

        // 애니메이션에 speed 값, ApplyAnimation은 오버로드 해도 될 듯
        if(Anim != null) {
            ApplyAnimation(direction.magnitude);
        }
    }

    private void ApplyAnimation(float speed) {
        Anim.SetFloat("Speed", speed);
    }

    public void SetAnimator(Animator anim) {
        Anim = anim;
    }
}