using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menubackgroundquad : MonoBehaviour
{  
    public float scrollSpeed = 0.5f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer> ();
    }

    void Update()
    {
        float offsetX = Time.time * scrollSpeed;
        
        rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX,0f));
    }
}
