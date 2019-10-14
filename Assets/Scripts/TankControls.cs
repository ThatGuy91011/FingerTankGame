using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankControls : MonoBehaviour
{
    private Transform tf;
    public GameObject pf;
    public float rotationSpeed;
    public float movingSpeed;

    public int lengthOfTime;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        pf = GameObject.FindWithTag("Bullet");
    }

    // Update is called once per frame
    void Update()
    {
        //If the up arrow is pressed...
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += transform.up * movingSpeed;
        }

        //If the down arrow is pressed...
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //...move the sprite backwards constantly at the speed you define
            tf.position -= transform.up * movingSpeed;
        }

        //If the left arrow is pressed...
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //...rotate the sprite to the left
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotationSpeed, Space.World);
        }

        //If the right arrow is pressed...
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //...rotate the sprite to the right
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * rotationSpeed, Space.World);
        }

        //Is Space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {

            //Shoot the bullet
            GameObject newObject = Instantiate(pf, tf.position, tf.rotation) as GameObject;
            Destroy(newObject, lengthOfTime);
        }

        //if S is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Suicide
            Destroy(this.gameObject);
        }


    }
}
