using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaterando : MonoBehaviour
{

    bool isPressed;

    void Start()
    {
        
    }

    void Update()
    {
        if(isPressed)   {
            OnClickLeft(); 
        }

        # Cube.transform.Rotate(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), Space.Self);

    }

    public void TogglePressed(bool value) {
        isPressed = value;
    }
}
