using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Create new game object
        GameObject newObject = new GameObject();

        //Make the bullet move
        Mover m = newObject.AddComponent<Mover>() as Mover;

        //Add speed to bullet
        m.speed = 10.0f;

        //Set position to 0,0,0
        newObject.GetComponent<Transform>().position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
