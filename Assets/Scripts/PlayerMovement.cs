using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 2500f;
    public float SidewatForce = 80f;
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Hello world!");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewatForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewatForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (rb.position.y <= -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
