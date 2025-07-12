using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] RectTransform mark;
    [SerializeField] Health health;

    private float originalWith;

    void Start()
    {
        originalWith = mark.sizeDelta.x;
        health.onHealthChanged += UpdateHealthValue;
    }

    private void UpdateHealthValue()
    {
        float scale = (float)health.healthPoint / health.defaulHealthPoint;
        mark.sizeDelta = new Vector2(scale * originalWith, mark.sizeDelta.y);
    }
}
