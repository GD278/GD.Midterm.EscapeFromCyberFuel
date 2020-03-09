using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    [SerializeField] float speed = 5.0f;
    [SerializeField] float turnSpeed;
    [SerializeField] float torque;
    [SerializeField] float VertSpeed;
    Rigidbody playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 forwardMovement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -turnSpeed, Space.Self);
           
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed, Space.Self);
            
        }
        if (Input.GetKey(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * VertSpeed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerRB.velocity = Vector3.zero;
        }
        if (Input.GetKey(KeyCode.X))
        {
            playerRB.AddForce(Vector3.down * VertSpeed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            playerRB.velocity = Vector3.zero;
        }
    }
}
