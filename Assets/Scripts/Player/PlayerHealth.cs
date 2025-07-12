using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    private void Awake()
    {
        healthPoint = defaulHealthPoint;
    }
    protected override void Die()
    {
        base.Die();
    }
}
