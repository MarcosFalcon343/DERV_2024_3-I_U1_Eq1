using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P4_CambiaMaterial : MonoBehaviour
{
    Renderer rend;
    [SerializeField]
    Material material1;
    [SerializeField]
    Material material2;

    int estado;
    void Start()
    {
        rend = GetComponent<Renderer>();
        estado = 0;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            if(estado == 0){
                estado = 1;
                rend.material = material1;
            }else{
                estado = 0;
                rend.material = material2;
            }
        }
    }
}
