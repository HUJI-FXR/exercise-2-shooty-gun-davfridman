using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerControlScript : MonoBehaviour
{

    private MovementScript movementScript;
    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<MovementScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            movementScript.MoveLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movementScript.MoveRight();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            movementScript.Jump();
        }
    }
}
