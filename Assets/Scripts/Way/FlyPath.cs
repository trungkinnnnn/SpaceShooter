using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPath : MonoBehaviour
{
    [SerializeField] WayPoint[] points;

    private void Reset() => points = GetComponentsInChildren<WayPoint>();
}
