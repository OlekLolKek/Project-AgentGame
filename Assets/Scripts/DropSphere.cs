using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSphere : MonoBehaviour
{

    public Rigidbody rigid;
    public GameObject MainCamera;
    public GameObject SecondCamera;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.useGravity = true;
            //MainCamera.SetActive(false);
            //SecondCamera.SetActive(true);
        }
	}

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            rigid.useGravity = true;
        }
    }
}
