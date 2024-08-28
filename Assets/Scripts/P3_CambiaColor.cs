using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3_CambiaColor : MonoBehaviour
{
    Renderer rend;
    [SerializeField]
    Color col;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    
    void Update()
    {
        //rend.material.color = Color.white;
        rend.material.color = col;
    }
}
