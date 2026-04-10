using NUnit.Framework;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Ball : MonoBehaviour
{
    Vector3 velocity = new Vector3(1, 2, 0);
    Vector3 direction;
    float Speed = 6;
    public int pointsRight;
    public int pointsleft;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = velocity.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * Speed;
        transform.position += velocity * Time.deltaTime;

        if(transform.position.x <= -7 || transform.position.x >= 7)
        {
            transform.position = Vector3.zero;
        }
        if(transform.position.x == -7)
        {
            pointsRight += 1;
        }
        else if(transform.position.x == 7)
        {
            pointsleft += 1;
        }
        Debug.Log("Points Right: " + pointsRight);
        Debug.Log("Points Left: " + pointsleft);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collided with " + collision.gameObject.tag);
        Debug.Log("Collided with " + collision.gameObject.tag);
        if (collision.gameObject.tag == "Wall")
        {
            direction.y = -direction.y;
        }
        else if (collision.gameObject.tag == "Pedal")
        {
            direction.x = -direction.x;
        }
    }
}
