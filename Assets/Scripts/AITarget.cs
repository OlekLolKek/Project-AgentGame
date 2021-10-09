using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AITarget : MonoBehaviour
{
    public NavMeshAgent agentik;
    public Transform target;
    public AudioSource AudioSource;
    public GameObject AudioSourceGO;
    public static bool MusicON = true;
    public static float Volume = 0;

	void Update ()
    {
        agentik.SetDestination(target.position);
        if(MusicON == true)
        {
            AudioSourceGO.SetActive(true);
        }
        else
        {
            AudioSourceGO.SetActive(false);
        }
        if (agentik.remainingDistance<0.5f)
        {
            Debug.Log("ДОШЛИ");
        }
        AudioSource.volume = Volume;
    }
}
