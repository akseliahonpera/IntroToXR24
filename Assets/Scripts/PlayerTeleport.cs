using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTeleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public InputActionReference togglePosition;
    public bool insideRoom;
    void Start()
    {
        //  light.color = Color.red;
        togglePosition.action.Enable();
        insideRoom = true;
        player.transform.position = new Vector3(2,5,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (togglePosition.action.triggered){
            if(insideRoom == true){
                player.transform.position = new Vector3(30,5,0);
                }
            else  {
            player.transform.position = new Vector3(2,5,0);
            }
            insideRoom ^= true;
        }
    }
}
