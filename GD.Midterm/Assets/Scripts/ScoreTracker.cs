using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text ScoreTextBox;
    [SerializeField] Text youWinTextBox;
    [SerializeField] Text replayTextBox;
    PlayerController playerController;
    Timer timer;
    [SerializeField] GameObject[] rings;
    bool triggered;
    
    
    int i;
    
    void Start()
    {
        i = 0;
        triggered = false;
        playerController = GetComponent<PlayerController>();
        timer = GetComponent<Timer>();
        replayTextBox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        triggered = false;
        if(i >= rings.Length)
        {
            youWinTextBox.text = "You Win!";
            playerController.enabled = false;
            timer.enabled = false;
            replayTextBox.enabled = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hoop") && !triggered)
        {
            triggered = true;
            Destroy(other.gameObject);
            Debug.Log("Hoop destroyed.");
            Debug.Log("You have entered the trigger.");
            i++;
            Debug.Log("Score added.");
            Destroy(other.gameObject);
            Debug.Log("Trigger destroyed.");
            ScoreTextBox.text = $"Score: {i}";
        }
    }
}
