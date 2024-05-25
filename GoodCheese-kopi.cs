using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCheese : Cheese
{
    private int cheeseCounter = 0;
    CheeseMeter _cheeseMeter;
    private bool canPickupCheese = true;

    public GoodCheese()
    {
        isStinkyCheese = false;
    }

    private void Start()
    {
        _cheeseMeter = FindObjectOfType<CheeseMeter>();
    }

    private void Pickup()
    {
        if (canPickupCheese)
        {
        cheeseCounter++;
        AudioManager.instance.playOneShot(FmodEvents.instance.cheesePickupSFX, this.transform.position);
        Debug.Log("Cheese Counter: " + cheeseCounter);
        _cheeseMeter.GetCheese();
            if (cheeseCounter >= 9)
            {
                GameFlow.Instance.GameWin();
            }
        }
    }
}
