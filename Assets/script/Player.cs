    using System;
using System.Collections;
using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

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
        WOn();
        rb.linearVelocity = moveInput * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Damage")
        {
                Die(); 
        }
    }
    private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }
    private void WOn()
    {
        if(coins == 100)
        {
            Debug.Log("furries");
            UnityEngine.SceneManagement.SceneManager.LoadScene("won");
        }
    } 
}
       