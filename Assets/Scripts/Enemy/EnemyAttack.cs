
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] EnemyHealth health;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerShip = collision.GetComponent<PlayerHealth>();
        if (playerShip == null ) return;

        playerShip.TakeDamge(damage);
        health.TakeDamge(1);
    }

}
