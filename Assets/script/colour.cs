using UnityEngine;

public class colour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(GameObject gameObj in GameObject.FindObjectsOfType<GameObject>())
           {
               if(gameObj.name == "Cube")
               {
                   gameObj.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
               }
           }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
