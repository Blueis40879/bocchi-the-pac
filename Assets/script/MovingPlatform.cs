using System.Numerics;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AI;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public Transform [] points;
    [SerializeField] Transform target;
    NavMeshAgent agent;
    private int i;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (UnityEngine.Vector2.Distance(transform.position, points[i].position) < 0.1f)
        //{
        //    i++;
        //    if (i == points.Length)
        //    {
       //         i = 0;
       //     }
       // }

        //transform.position = UnityEngine.Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        agent.SetDestination(target.position);
    }

}
