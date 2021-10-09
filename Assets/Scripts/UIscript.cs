using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIscript : MonoBehaviour
{
    public Text TextElement;
    public float Timer;
    public float TrueTimer;
    public GameObject Prefab;
    public bool NotCreated;
    public int Score;
    public PointsData data;
    public PointsInf inf;

    public BallDestroy bd;

    void Awake()
    {
        
    }

    // Use this for initialization
    void Start ()
    {
        TrueTimer = 3;
        NotCreated = true;
        TextElement.text = inf.SCORE.ToString("0");
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timer = Timer + 1;

        TrueTimer = TrueTimer - Time.deltaTime;

        TextElement.text = inf.SCORE.ToString("0");

        //if (Score >= 6)

        //{
        //    TextElement.color = new Color(0, 1, 0, 1);
        //    TextElement.text = ("VICTORY");
        //}
        //if (TrueTimer <= 0)
        //{
        //    if(NotCreated)
        //    {
        //        Instantiate(Prefab);
        //        NotCreated = false;
        //    }
        //}
    }

    void LateUpdate()
    {

    }

    void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }



}