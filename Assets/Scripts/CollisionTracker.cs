using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem fire;
    [SerializeField] Text GameOverText;
    [SerializeField] Text replayTextBox;
    PlayerController playerController;
    Rigidbody playerRb;
    Timer timer;
    bool gameOver;
    private void Awake()
    {
        fire.Stop();
    }
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        playerRb = GetComponent<Rigidbody>();
        timer = GetComponent<Timer>();
        replayTextBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true)
        {
            timer.enabled = false;
            playerRb.useGravity = true;
            replayTextBox.enabled = true;
            playerController.enabled = false;
            GameOverText.text = "Game over!";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag == "Player" && collision.gameObject.tag == "Obstacle")
        {
            fire.Play();
            gameOver = true;
        }
    }
}
