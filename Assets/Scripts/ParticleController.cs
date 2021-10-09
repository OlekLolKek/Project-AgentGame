using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour {

    public ParticleSystem particle;
	// Use this for initialization
	void Start ()
    {
        var em = particle.emission;
        em.enabled = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
