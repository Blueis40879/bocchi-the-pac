using System;
using System.Collections;
using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class hi : MonoBehaviour
{
        public float movespeed = 5f;
        private AudioSource AudioSource;
        public int coins;

        public int health = 100;
        public const int maxhealth = 100;
        public float jumpforce = 10f;
        public Transform groundcheck;
        public float groundcheckradius = 0.2f;
        public LayerMask GroundLayer;
        private Rigidbody2D rb;
        private bool isgrounded;
        public int extraJumpsValue = 1;
        private int extrajumps;
        private SpriteRenderer spriteRenderer;
        float timer= 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        extrajumps = extraJumpsValue;
        spriteRenderer = GetComponent<SpriteRenderer>();
        AudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.2f)
        {
            ToggleColor();
            timer = 0f;
        }
        
    }
    private IEnumerator BlinkRed()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
    }
    private IEnumerator Blinkpink()
    {
        spriteRenderer.color = Color.pink;
        yield return new WaitForSeconds(0.1f);
    }
    private void ToggleColor()
    {
        if(spriteRenderer.color == Color.pink)
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.pink;
        }
    }
}
