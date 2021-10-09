using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorPoints : MonoBehaviour {

    public PointsData data;
    public UIscript ui;
    public PointsInf inf;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PointsData>() != null)
        {
            PointsData data = other.GetComponent<PointsData>();
            inf.SCORE = inf.SCORE + 100;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
    }
}
