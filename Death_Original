using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    SpriteRenderer sprite;
    [SerializeField] Sprite deadMouse;

    public void Die()
    {
        AudioManager.instance.playOneShot(FmodEvents.instance.crash, this.transform.position);
        StopAllCoroutines();

        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = deadMouse;

    }
}

