using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackGround : MonoBehaviour
{
    [SerializeField] Renderer _bgRenderer;
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        _bgRenderer.material.mainTextureOffset = new Vector2(0, speed * Time.time);
    }
}
