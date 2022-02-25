using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    [SerializeField] float backgroundScrollSpeed = 0.2f;

    Material material;
    Vector2 offset;


    private void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(0f, backgroundScrollSpeed);
    }

    private void FixedUpdate()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }        
}
