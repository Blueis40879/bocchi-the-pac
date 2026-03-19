using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float dashSpeed = 15f;

    private Rigidbody2D rb;

    private Vector2 moveInput;
    private Vector2 dashDirection;
    public int coins;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(moveX, moveY).normalized;

        rb.linearVelocity = moveInput * moveSpeed;
    }
}
       