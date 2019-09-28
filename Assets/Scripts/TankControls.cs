using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the up arrow is pressed...
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += transform.up * .2f;
        }

        //If the down arrow is pressed...
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //...move the sprite backwards constantly at the speed you define
            tf.position -= transform.up * .1f;
        }

        //If the left arrow is pressed...
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //...rotate the sprite to the left
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * 90f, Space.World);
        }

        //If the right arrow is pressed...
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //...rotate the sprite to the right
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * 90f, Space.World);
        }
    }
}
