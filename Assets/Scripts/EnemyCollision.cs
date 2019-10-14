using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
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

    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        //Only destroys the object if it is the player
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
        
    }
}
