using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float timer;
    [SerializeField] Text timerTextBox;
    [SerializeField] Text gameOverTextBox;
    PlayerController playerController;
    bool gameOver;
    
    void Start()
    {
        gameOver = false;
        playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerTextBox.text = $"{Mathf.Round(timer * 10) /  10f}";

        if(timer <= 0)
        {
            gameOver = true;
        }

        if (gameOver == true)
        {
            gameOverTextBox.text = " Game Over";
        }
    }
}
