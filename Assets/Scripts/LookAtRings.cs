using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtRings : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ScoreTracker scoreTracker;
    private Transform waypoint;
    void Start()
    {
        //scoreTracker = GetComponent<ScoreTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        waypoint = scoreTracker.getCurrentRing().transform;
        transform.LookAt(waypoint);
    }
}
