using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] GameObject EffectDestroy;

    public int defaulHealthPoint;
    public int healthPoint;

    public System.Action onDead;
    public System.Action onHealthChanged;

    private void Start()
    {
        onHealthChanged?.Invoke();
    }


    public void TakeDamge(int damge)
    {
        if(healthPoint <= 0) return;

        healthPoint -= damge;
        onHealthChanged.Invoke();

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
