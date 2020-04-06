using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRings : MonoBehaviour
{
    // Start is called before the first frame update
    ScoreTracker scoreTracker;
    
    void Start()
    {
        scoreTracker = GetComponent<ScoreTracker>();
    }

    // Update is called once per frame
    public void RingInstantiate()
    {
        scoreTracker.rings[scoreTracker.i].SetActive(true);
    }
}
