using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    private Transform tf;
    private Vector3 SpawningAtStart;
    private Transform ptf;
    private Component pspawning;
    private GameObject Player;
    private Vector3 TargetVector;
    public float enemyMovingSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //Random spawning
        SpawningAtStart = new Vector3(Random.Range(-14, 14), Random.Range(-14, 14), 0);
        tf = GetComponent<Transform>();
        tf.position = SpawningAtStart;

        //Find the game object
        Player = GameObject.Find("Finger");
        ptf = Player.GetComponent<Transform>();
        TargetVector = new Vector3(ptf.position.x, ptf.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        //Move towards the player
        tf.position = Vector3.MoveTowards(tf.position, TargetVector, enemyMovingSpeed * 1);
        

    }


}
