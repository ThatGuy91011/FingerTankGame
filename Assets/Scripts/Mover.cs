using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Transform tf;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myVector = new Vector3(2, 0, 0);
        myVector = myVector.normalized;
        tf.position += (myVector * speed);
    }
}
