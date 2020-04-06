using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables
    [SerializeField] float speed = 5.0f;
    [SerializeField] float turnSpeed;
    [SerializeField] float VertSpeed;
    private Vector3 rotationVelocity;
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
            playerRB.velocity = new Vector3(speed, 0, 0);
            //use velocity start with velocity at zero and modify based on what they press.
            //use velocity to move player up as well. 
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerRB.velocity = Vector3.zero;
        }
        //Moves player backwards
        if (Input.GetKey(KeyCode.S))
        {
            playerRB.velocity = new Vector3(-speed, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerRB.velocity = Vector3.zero;
        }
        //Rotates player left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed, Space.Self);
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
