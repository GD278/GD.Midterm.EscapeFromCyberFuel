using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveScript : MonoBehaviour
{
    [SerializeField] Text ObjectiveTextBox;
    // Start is called before the first frame update
    void Start()
    {
        ObjectiveTextBox.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            ObjectiveTextBox.enabled = false;
        }
    }
}
