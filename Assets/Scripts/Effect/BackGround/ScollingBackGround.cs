using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScollingBackGround : MonoBehaviour
{
    [SerializeField] private Renderer bgRenderer;
    public float speed = 0.3f;
    void Update()
    {
        bgRenderer.material.mainTextureOffset = new Vector2(0, Time.time * speed);
    }
}
