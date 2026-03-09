using UnityEngine;
using System.Collections.Generic;

public class walking : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
     GameObject objToSpawn;
     public GameObject prefab;
     private GameObject spawnedobject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (spawnedobject == null)
            {
                spawnedobject = Instantiate(prefab, transform.position, Quaternion.identity);
            }
            else
            {
                spawnedobject.transform.position = transform.position;
                spawnedobject.name = prefab.name; 
            }
        }
    }
}
