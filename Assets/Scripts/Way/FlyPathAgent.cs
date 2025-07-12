using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath flyPath;
    public float flySpeed = 0.5f;
    private int nextIndex = 1;
    public float speedAngle = 1f;

    private void Update()
    {
        if (flyPath == null) return;
        if (nextIndex >= flyPath.points.Length)
        {
            Destroy(gameObject);
            EnemyHealth.enemyLiving -= 1;
            return;
        }

        if(transform.position != flyPath[nextIndex])
        {
            FlyToNextWayPoint();
            LookAt(flyPath[nextIndex]); 
        }
        else
        {
            nextIndex += 1;
        }
    }

    private void FlyToNextWayPoint() 
        => transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex], flySpeed * Time.deltaTime);

    private void LookAt(Vector2 destination)
    {
        Vector2 postion = transform.position;

        var lookDirection = destination - postion;

        if (lookDirection.sqrMagnitude < 0.001f) return;

        var angleTarget = Vector2.SignedAngle(Vector2.down, lookDirection);

        Quaternion targetRotation = Quaternion.Euler(0, 0, angleTarget);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, speedAngle * Time.deltaTime);
    }

}
