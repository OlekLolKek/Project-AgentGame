using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour {

    public Vector3 vector;
    public UIscript ui;
    public GameObject Wall1;
    public DropSphere ds;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Движение влево
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.5f, 0, 0);
        }
        //Движение вправо
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-0.5f, 0, 0);
        }
        //Движение вниз
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, 0.5f);
        }
        //Движение вверх
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -0.5f);
        }
	}

    //private void OnTriggerEnter(Collider other)
    //{
    //    Destroy(other.gameObject);
    //    ui.Score++;
    //}

    public void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            ds.rigid.useGravity = true;
            ds.MainCamera.SetActive(false);
            ds.SecondCamera.SetActive(true);

        }
    }

}
