using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtRings : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreTracker scoreTracker;
    void Start()
    {
        scoreTracker = GetComponent<ScoreTracker>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = scoreTracker.rings[scoreTracker.i].transform.position;
        transform.LookAt(target);
    }
}
