using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject Asteroid;

    private GameObject Ship;

    private Transform atf;

    private Transform stf;

    private int choice;

    public int HowMany;
    public static GameManager instance;
    public ArrayList enemiesList;
    void Awake()
    {
        // As long as there is not an instance already set
        if (instance == null)
        {
            instance = this; // Store THIS instance of the class (component) in the instance variable
            DontDestroyOnLoad(gameObject); // Don't delete this object if we load a new scene
        }
        else
        {
            Destroy(this.gameObject); // There can only be one - this new object must die
            Debug.Log("Warning: A second game manager was detected and destroyed.");
        }

        Asteroid = GameObject.Find("Asteroid");
        atf = Asteroid.GetComponent<Transform>();
        Ship = GameObject.Find("EnemyShip");
        stf = Ship.GetComponent<Transform>();

        Debug.Log(HowMany);
        if (HowMany <= 1)
        {
            if (Random.value <= 0.5)
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
