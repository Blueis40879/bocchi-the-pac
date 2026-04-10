    using System;
using System.Collections;
using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class pedal : MonoBehaviour
{
    public float moveSpeed = 5f;


    private Vector2 moveInput;
    public int coins;

    void Start()
    {
    }

    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized;
    }
}
