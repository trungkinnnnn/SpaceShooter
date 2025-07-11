using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject EffectDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet"))
        {
            Die();
        }    
    }    

    private void Die()
    {
        var explosion = Instantiate(EffectDestroy, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }    

}
