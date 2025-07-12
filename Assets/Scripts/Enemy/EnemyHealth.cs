using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int enemyLiving;

    private void Awake()
    {
        enemyLiving += 1;
        healthPoint = defaulHealthPoint;
    }    

    protected override void Die()
    {
        enemyLiving -= 1;
        base.Die();
    }    

}
