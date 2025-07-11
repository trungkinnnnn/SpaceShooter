using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 5f;

    void Update()
    {
        var newPostion = transform.position;
        newPostion.y += flySpeed * Time.deltaTime;
        transform.position = newPostion;

        var min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0));
        var max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1));

        if(newPostion.x < min.x - 0.5f || newPostion.x > max.x + 0.5f
            || newPostion.y < min.y - 0.5f || newPostion.y > max.y + 0.5)
        {
            Destroy(gameObject);
        }

    }
}
