using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTexture : MonoBehaviour
{
    public Vector2 moveSpeed;
    private Renderer Renderer {
        get; set;
    }

    private void Start() {
        Renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        Renderer.material.mainTextureOffset += moveSpeed * Time.deltaTime;
    }
}
