using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRings : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreTracker scoreTracker;
    int i = 0;
    void Start()
    {
        scoreTracker = GetComponent<ScoreTracker>();
    }

    // Update is called once per frame
    public void RingInstantiate()
    {
        GameObject Ring = Instantiate(scoreTracker.rings[i]);
    }
}
