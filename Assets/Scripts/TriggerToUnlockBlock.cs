using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToUnlockBlock : MonoBehaviour
{

    public GameObject UnlockableObject;
    public GameObject UO2;
    public GameObject UO3;
    public void OnTriggerEnter(Collider other)
    {
        UO2.SetActive(true);
        UO3.SetActive(true);
        UnlockableObject.SetActive(true);
        other.gameObject.SetActive(false);
    }

    private void Update()
    {
        
    }

}
