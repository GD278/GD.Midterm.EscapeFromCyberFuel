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
        //Moves player forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        //Moves player backwards
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        //Rotates player left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -turnSpeed, Space.Self);
           
        }
        //Rotates player right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed, Space.Self);
            
        }
        //Moves player up
        if (Input.GetKey(KeyCode.Space) && transform.position.y <= 14.0f)
        {
            playerRB.AddForce(Vector3.up * VertSpeed * Time.deltaTime, ForceMode.Impulse);
        }
        //Stop player from moving up
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerRB.velocity = Vector3.zero;
        }
        //moves player down
        if (Input.GetKey(KeyCode.X))
        {
            playerRB.AddForce(Vector3.down * VertSpeed * Time.deltaTime, ForceMode.Impulse);
        }
        //stops player from moving down
        if (Input.GetKeyUp(KeyCode.X))
        {
            playerRB.velocity = Vector3.zero;
        }

        //Detects where player is at in sky. If greater than x player will not be able to move up
        if(transform.position.y >= 14.0f)
        {
            playerRB.velocity = Vector3.zero;
        }
    }
}
