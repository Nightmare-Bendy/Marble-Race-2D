using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bop : MonoBehaviour
{
    public Transform start;
    public Transform Stop;
    public float speed=1f;
    private float startTime;
    private float Distance;
    // Start is called before the first frame update
    void Start()
    {
        transform.position=start.position;
        startTime=Time.time;
        Distance=Vector3.Distance(start.position, Stop.position);
    }

    // Update is called once per frame
    void Update()
    {
        float DTraveled=(Time.time-startTime)*speed;
        float FTraveled=DTraveled/Distance;
        transform.position=Vector3.Lerp(start.position, Stop.position, FTraveled);
        if(FTraveled>=1)
        {
            Vector3 TStartStop=start.position;
            start.position=Stop.position;
            Stop.position=TStartStop;
            startTime=Time.time;
        }
    }
}
