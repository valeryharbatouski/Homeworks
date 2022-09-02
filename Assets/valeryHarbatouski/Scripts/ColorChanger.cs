using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer _render;

    void Start()
    {
        _render = GetComponent<Renderer>();

    }
    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("c"))
        {
            _render.material.color = Color.cyan;
        }
        
    }
}
