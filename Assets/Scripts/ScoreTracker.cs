using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] Text ScoreTextBox;
    [SerializeField] Text youWinTextBox;
    [SerializeField] Text replayTextBox;
    PlayerController playerController;
    Timer timer1;
    public GameObject[] rings;
    bool triggered;

    InstantiateRings instantiateRings;
    public int i;
    
    void Start()
    {
        i = 0;
        triggered = false;
        playerController = GetComponent<PlayerController>();
        instantiateRings = GetComponent<InstantiateRings>();
        timer1 = GetComponent<Timer>();
        replayTextBox.enabled = false;
        Debug.Log(getCurrentRing());
    }

    // Update is called once per frame
    void Update()
    {
        triggered = false;
        if(i >= rings.Length)
        {
            youWinTextBox.text = "You Win!";
            playerController.enabled = false;
            timer1.enabled = false;
            replayTextBox.enabled = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hoop") && !triggered)
        {
            timer1.timer++;
            triggered = true;
            Destroy(other.gameObject);
            Debug.Log("Hoop destroyed.");
            Debug.Log("You have entered the trigger.");
            i++;
            instantiateRings.RingInstantiate();
            //Debug.Log("Score added.");
            Destroy(other.gameObject);
            Debug.Log("Trigger destroyed.");
            //ScoreTextBox.text = $"Score: {i}";
        }
    }

    public GameObject getCurrentRing()
    {
        return rings[i];
    }
}
