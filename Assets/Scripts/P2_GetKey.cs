using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_GetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("Space key is W");
        }
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Space key is A");
        }
                if(Input.GetKey(KeyCode.S))
        {
            Debug.Log("Space key is S");
        }
                if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Space key is D");
        }
    }
}
