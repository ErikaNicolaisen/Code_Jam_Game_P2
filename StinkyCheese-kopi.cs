using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StinkyCheese : Cheese
{
    private float acclAmount;
    [SerializeField] float shakeAmount = 0.3f;
    [SerializeField] float fallSpeed = 0f;
    private int gravity = 1;

    private void Update()
    {
        acclAmount = Mathf.Abs(Input.acceleration.y);

        if (isStinkyCheese == true)
        {
            if (acclAmount > shakeAmount)
            {
                Debug.Log("Stinky cheese accelerometer");
                isStinkyCheese = false;
                this.gameObject.GetComponent<Rigidbody2D>().gravityScale = gravity;
                this.gameObject.GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }

    private void StopMovement()
    {
        if (isStinkyCheese == true)
        {
            if (PlayerVFX.Instance.IsPlayerDead() != true)
            {
                AudioManager.instance.playOneShot(FmodEvents.instance.badCheese, this.transform.position);
            }
            Debug.Log("Stinky cheese running");
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
            this.gameObject.GetComponent<PlayerMovement>().enabled = false;
            fallSpeed = -2f;
            transform.position = new Vector3(transform.position.x, transform.position.y + fallSpeed * Time.deltaTime, transform.position.z);
            Physics.IgnoreLayerCollision(0, 1);
            Debug.Log("Stinky Accl: " + Input.acceleration.y);
        }

    }
}

