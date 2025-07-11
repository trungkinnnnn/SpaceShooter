using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject EffectDestroy;

    public int defaulHealthPoint;
    private int healthPoint;
    public System.Action onDead;

    private void Start()
    {
        healthPoint = defaulHealthPoint;
    }


    public void TakeDamge(int damge)
    {
        if(healthPoint <= 0) return;

        healthPoint -= damge;

        if(healthPoint <= 0) Die();
    }    


    protected virtual void Die()
    {
        var explosion = Instantiate(EffectDestroy, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
        onDead?.Invoke();
    }
}
