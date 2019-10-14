using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
    private GameObject Asteroid;

    private GameObject Ship;

    private Transform atf;

    private Transform stf;

    private int choice;

    public int HowMany;
    // Start is called before the first frame update
    void Start()
    {
        Asteroid = GameObject.Find("Asteroid");
        atf = Asteroid.GetComponent<Transform>();
        Ship = GameObject.Find("EnemyShip");
        stf = Ship.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(HowMany);
        if (HowMany <= 1)
        { if (Random.value <= 0.5)
            {
                atf.position = new Vector3(Random.Range(-14, 14), Random.Range(-14, 14), 0);
                GameObject newObject = Instantiate(Asteroid, atf.position, atf.rotation) as GameObject;
                HowMany += 1;
            }
        else
            {
                stf.position = new Vector3(Random.Range(-14, 14), Random.Range(-14, 14), 0);
                GameObject newObject = Instantiate(Ship, stf.position, stf.rotation) as GameObject;
                HowMany += 1;
            }
        }
    }
}
