using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // OnCollisionEnter is called whenever two objects collides
    public PlayerMovement1 movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //No more forces exerting in either direction
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
