using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Liv : MonoBehaviour
{
    [SerializeField] public Image livSpriteRenderer;
    public float maxFillLevel = 3f;
    public float fillLevel;
    Death death;

    void Start()
    {
        fillLevel = maxFillLevel;
        UpdateLivSprite();
        death = FindAnyObjectByType<Death>();
    }
    
    public void DecreaseFillLevel(float amount)
    {
        fillLevel -= amount;
        if (fillLevel <= 0)
        {
            fillLevel = 0;
            death.Die();
        }
        UpdateLivSprite();
    }

    private void UpdateLivSprite()
    {
        float fillAmount = fillLevel / maxFillLevel;
        livSpriteRenderer.fillAmount = fillAmount;
    }
}
