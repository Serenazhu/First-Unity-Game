using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public Rigidbody rb;

    public Transform pposition;

    public float forwardForce = 2000f; //Adding public enables you to edit the value in the inspector
    public float rightwayForce = 500f;
    public float leftwayForce = -500f;
    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0, 300, 500);  //(x, y, z)
    }

    // Update is called once per frame
    // Use FixedUpdate for physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // time in seconds it took to complete the last frame. The faster it completes, the lower the time value which *2000 makes the speed slower
        if (Input.GetKey("d")) //RIGHT
        {
            rb.AddForce(rightwayForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")) //LEFT
        {
            rb.AddForce(leftwayForce * Time.deltaTime, 0, 0);
        }
        if (pposition.position.y < -10)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
