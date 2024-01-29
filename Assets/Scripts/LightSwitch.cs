using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference toggleLightColor;
    public bool primaryLight;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
      //  light.color = Color.red;
        toggleLightColor.action.Enable();
        primaryLight = true;
    }

    // Update is called once per frame
    void Update()
    {
         if (toggleLightColor.action.triggered){
            if(primaryLight == true){
                light.color = Color.green;
                }
            else  {
            light.color = Color.red;
            }
            primaryLight ^= true;
        }

    }
}
