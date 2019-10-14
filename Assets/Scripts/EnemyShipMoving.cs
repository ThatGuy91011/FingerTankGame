using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyShipMoving : MonoBehaviour
{

    public float RotateSpeed;

    public float MoveSpeed;

    private Transform tf;

    private float rotate;

    private GameObject Player;

    private Transform ptf;

    private Vector3 CorrectVector;

    private Vector3 TestVector;

    private int check;

    private Vector3 SpawningAtStart;

    // Start is called before the first frame update
    void Start()
    {
        //Random spawning
        SpawningAtStart = new Vector3(Random.Range(-14, 14), Random.Range(-14, 14), 0);
        tf = GetComponent<Transform>();
        tf.position = SpawningAtStart;

        //Finds the player
        Player = GameObject.Find("Finger");
        ptf = Player.GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        //Failed moving
        if (check == 0)
        {
            Vector3 CorrectVector = (ptf.position - tf.position).normalized;
            tf.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * RotateSpeed, Space.World);
            Vector3 TestVector = new Vector3(0, 0, tf.rotation.z);
            if (TestVector == CorrectVector)
            {
                check = 1;
            }
        }

        else
        {
            tf.position = Vector3.MoveTowards(tf.position, ptf.position, MoveSpeed * 1);
        }

 
    


    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            Destroy(this.gameObject);
        }

    }
}
