using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    public static Cheese Instance = null;

    public bool isStinkyCheese;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    //this script should also have code for spawning the different cheeses
    //which can be overriden in the two childclasses, but for now, this is
    //implemented in the CelestialBodySpawner. For now the child and parent
    //classes only consists of the behavior of the different cheeses.

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
