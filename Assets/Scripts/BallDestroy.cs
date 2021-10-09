using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour {

    public UIscript ui2;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
            Destroy(other.gameObject);
        ui2.TextElement.text=("GAME OVER");
    }
}
