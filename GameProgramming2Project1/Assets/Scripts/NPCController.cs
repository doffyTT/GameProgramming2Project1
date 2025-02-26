using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    //Declaring my variables
    public string NPCname = "Joe";
    public int health;
    public int speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //set a variable to hold position information
        Vector3 newPosition = transform.position;

        //change the variable information according to player input
        if (Input.GetKey("d"))
        {
            newPosition.x += .01f;
        }

        if (Input.GetKey("a"))
        {
            newPosition.x -= .01f;
        }

        if (Input.GetKey("w"))
        {
            newPosition.y += .01f;
        }

        if (Input.GetKey("s"))
        {
            newPosition.y -= .01f;
        }

        //Update transform.position (actual position of the object)
        transform.position = newPosition;

    }

    }