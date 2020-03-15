using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCarAnim : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 5 * Time.deltaTime);
        new WaitForSeconds(5);
        transform.Translate(Vector3.down * 5 * Time.deltaTime);
        new WaitForSeconds(5);
    }
}
