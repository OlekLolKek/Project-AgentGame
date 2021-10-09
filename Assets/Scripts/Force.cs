using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    public Rigidbody MyRigidbody;
    public Vector3 ForceVector;
    public Vector3 TorqueVector;
	// Use this for initialization
	void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyRigidbody.AddForce(ForceVector, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MyRigidbody.AddTorque(ForceVector);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MyRigidbody.AddTorque(-ForceVector);
        }

    }
}
