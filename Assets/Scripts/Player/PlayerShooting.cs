using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    public float delayShooting = 1f;
    public float lastTimeShooting = 0f;

    void Update()
    {
        if (Time.time - lastTimeShooting > delayShooting)
        {
            Shooting();
            lastTimeShooting = Time.time;
        }
    }

    private void Shooting()
    {
        Vector3 bulletPosition = transform.position;
        bulletPosition.y = bulletPosition.y + 1f;
        Instantiate(bulletPrefab, bulletPosition, transform.rotation);
    }
}
