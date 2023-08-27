using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector2 _direction;
    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rb.MovePosition( _rb.position + _direction * (speed * Time.fixedDeltaTime));
    }
}
