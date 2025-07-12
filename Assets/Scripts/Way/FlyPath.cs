using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public WayPoint[] points;

    private void Reset() => points = GetComponentsInChildren<WayPoint>();

    public Vector3 this[int index] => points[index].transform.position;

    private void OnDrawGizmos()
    {
        if (points == null) return;    

        Gizmos.color = Color.green;

        for(int i = 0; i < points.Length - 1; i++)
        {
            Gizmos.DrawLine(points[i].transform.position, points[i + 1].transform.position);
        }

    }

}
