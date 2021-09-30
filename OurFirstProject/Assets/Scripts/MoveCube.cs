using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube: MonoBehaviour
{
    // we define global variables here so we can call them from any method
    private Rigidbody cubeRigidbody;	// we define rigidbody component
    public float force = 5f;	// we define force multiplier

    // Start is called before the first frame update
    void Start()
    {
        cubeRigidbody = GetComponent<Rigidbody>();	// we instantiate rigidbody component
    }

    // Update is called once per frame
    void Update()
    {
        float forwardBackwardArrow = Input.GetAxisRaw("Vertical");	// we get "vertical" inputs (up & down arrows or w & s keys)
        float leftRightArrow = Input.GetAxisRaw("Horizontal");	// we get "horizontal" inpuss (left & right arrows or a & d keys)

        Vector3 resultantForce = new Vector3(leftRightArrow, 0f, forwardBackwardArrow) * force;	// we put the input values into a sinlge variable

        cubeRigidbody.AddForce(resultantForce, ForceMode.Force);	// we move the cube by using the rigibody's built-in function
    }
}