using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float MovementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        // if the player is hitting down the W key they will move forward. Otherwise if they hit the S key they will move backward.
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * MovementSpeed;
        }
        else
            if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * MovementSpeed;
        }
        // if the player hits the A key they go left. Otherwise if they hit the D key they go right.
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * Time.deltaTime * MovementSpeed;
            }
            else
                if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * Time.deltaTime * MovementSpeed;
            }
        }
    }


}
